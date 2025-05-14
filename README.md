# hugo-driis
My [personal website, driis.dk](https://www.driis.dk) as a hugo static content site 

This was converted from a legacy homegrown solution into Hugo in 2020.

On deploys to master, we deploy to Github Pages via the Github Actions workflow: [hugo.yml](.github/workflows/hugo.yml).

The changes is published to the main domain at https://www.driis.dk

Directory structure:
* legacy: A json dump of the legacy data and a small .NET Core console program to convert it into Hugo format
* driis.dk: The Hugo version of [driis.dk](https://www.driis.dk)
