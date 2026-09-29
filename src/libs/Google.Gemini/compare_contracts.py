#!/usr/bin/env python3
"""Report meaningful drift in the two checked-in Gemini API contracts."""

import json
import sys


def report_section(name, previous, current):
    before = set(previous)
    after = set(current)
    for key in sorted(after - before):
        print(f"  + {name}: {key}")
    for key in sorted(before - after):
        print(f"  - {name}: {key}")
    for key in sorted(before & after):
        if previous[key] != current[key]:
            print(f"  ~ {name}: {key}")


def compare(label, previous_path, current_path):
    with open(previous_path, encoding="utf-8") as file:
        previous = json.load(file)
    with open(current_path, encoding="utf-8") as file:
        current = json.load(file)
    if previous == current:
        print(f"{label}: current")
        return False

    print(f"{label}: contract drift detected")
    report_section("path", previous.get("paths", {}), current.get("paths", {}))
    report_section(
        "schema",
        previous.get("components", {}).get("schemas", {}),
        current.get("components", {}).get("schemas", {}),
    )
    if {key: value for key, value in previous.items() if key not in ("paths", "components")} != {
        key: value for key, value in current.items() if key not in ("paths", "components")
    }:
        print("  ~ top-level metadata")
    if {key: value for key, value in previous.get("components", {}).items() if key != "schemas"} != {
        key: value for key, value in current.get("components", {}).items() if key != "schemas"
    }:
        print("  ~ other components")
    return True


if __name__ == "__main__":
    if len(sys.argv) != 5:
        raise SystemExit("usage: compare_contracts.py old-discovery new-discovery old-nextgen new-nextgen")
    changed = [
        compare("Discovery", sys.argv[1], sys.argv[2]),
        compare("NextGen", sys.argv[3], sys.argv[4]),
    ]
    raise SystemExit(1 if any(changed) else 0)
