#!/bin/sh

# If a command fails then the deploy stops
set -e

pushd driis.dk
hugo
cd public
git add .
# Commit changes.
msg="Publish site $(date)"
git commit -m "$msg"
git push 
popd
