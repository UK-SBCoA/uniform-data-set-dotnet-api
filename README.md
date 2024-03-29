[![BSD-2 "Simplified" License](https://img.shields.io/github/license/UK-SBCoA/uniform-data-set-dotnet-api)](https://github.com/UK-SBCoA/uniform-data-set-dotnet-api/LICENSE) ![GitHub Super-Linter](https://github.com/UK-SBCoA/uniform-data-set-dotnet-api/actions/workflows/super-linter.yml/badge.svg)
# UDS for .NET - Web API

This repository includes all necessary tools backend service to collect data for UDS including

* Class libraries for data-transer objects and API client wrapper
* Data persistence via web API
* Builds for Docker image [![Docker image build](https://github.com/UK-SBCoA/uniform-data-set-dotnet-api/actions/workflows/container-release.yml/badge.svg?branch=release)](https://github.com/orgs/UK-SBCoA/packages/container/package/uniform-data-set-dotnet-api)

This software is intended for use by [National Institute on Aging (NIA) Alzheimer's Disease Research Centers](https://www.nia.nih.gov/research/dn/national-alzheimers-coordinating-center-nacc) (ADRCs) to collect data for submission to the National Alzheimer's Coordinating Center ([NACC](https://naccdata.org/)) centralized database.

These data are called Uniform Data Set (UDS). All ADRC's submit this data frequently to contribute to the NIA's Alzheimer's Disease Longitudinal Study. Subsequent data can be requested by researchers across the world.

The software is implemented with several .NET tools and includes docker containers for ease of use. You may choose to use the source code or simply deploy a production container to your cloud storage provider. [More documentation can be found in our wiki.](https://github.com/UK-SBCoA/uniform-data-set-dotnet/wiki)

## Contributing
Thank you for interest in [contributing](CONTRIBUTING.md) to our project! There are many ways you can help:
* Submit bugs and feature requests [here](../../discussions)
* Submit a fix by [forking and submitting a PR Request](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request-from-a-fork)

## Security
[Security reports](SECURITY.md)

## Feedback
* Request a [new feature](../../discussions)
* Submit a [bug report](../../issues)
* [Upvote](../../discussions) popular feature requests

Read our [wiki](../../wiki) for more detailed information on each of these topics.

## License
The forms included in this repository are copyrighted. Detailed copyright statements and usage restrictions are available on each form and on the [NACC site](https://naccdata.org/data-collection/guidelines-copyright). Non-ADRC researchers who wish to use the forms in this repository should [complete and return a permission request](https://files.alz.washington.edu/nacc-permission-form.pdf).

Code in this repository is Copyright (c) University of Kentucky Sanders-Brown Center on Aging. All rights reserved. Licensed under the BSD 2-Clause "Simplified" License.
