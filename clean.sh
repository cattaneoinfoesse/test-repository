#!/bin/bash
find . -type d -iname obj -exec rm -rf "{}" \;
find . -type d -iname bin -exec rm -rf "{}" \;
find . -type d -iname .vs -exec rm -rf "{}" \;
tree -d -I Properties