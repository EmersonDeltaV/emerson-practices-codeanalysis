# Introduction
This document explains how to use `.editorconfig` files to enhance code readability and maintain cleaner source code.

# Templates

## Default

* Location: `\.editorconfig`
* Purpose: This is the **default** editor config file for Visual Studio solution (*.sln) files. It should be placed in the same directory as the solution file.

## Suggestive

* Location: `CodeAnalysis\Suggestive\.editorconfig`
* Purpose: If you plan to enable code analysis for an existing project, start by adding this `.editorconfig` file to the project. Use it until the project aligns with the default `.editorconfig` requirements.

## None

* Location: `CodeAnalysis\None\.editorconfig`
* Purpose: Use this file to *ignore code analysis* for a specific Visual Studio project.

# How to Use

## Editor Config

### Within This Solution

#### For a New Project

1. No additional work is needed; the *Default* `.editorconfig` will take effect automatically when a new project is created.

#### For an Existing Project

1. If possible, use the *Default* editor config promptly.
2. Otherwise, evaluate whether the project should be ignored or not.
3. Copy the appropriate template (either *None* or *Suggestive*) into the project.
4. Test the code analyzer by building the project.

### For a New or Existing Solution

1. Copy the `CodeAnalysis` folder and the `.editorconfig` from this Git repository’s main folder into your new repository.
2. Evaluate which `.editorconfig` template each project should use. Initially, consider using the *None* template to minimize effort. Over time, gradually promote the use of the *Suggestive* template for each project.

## Setup and Use Code Cleanup

1. Update the Cleanup Code Profile 1
   * Include the following fixers:
       * Fix all warnings and errors set in EditorConfig
       * Fix analyzer warnings and errors set in EditorConfig
2. Configure Cleanup Code on Save
    a. Navigate to Options > Text Editor > Code Cleanup
    b. Select “Profile 2” from the dropdown
    c. Check “Run Code Cleanup profile on Save”
    d. Click OK to save changes
3. When working with `.cs` files, to automatically run the Analyzer’s recommendation, press “CTRL+K”, “CTRL+E”
   * This will execute the Code Cleanup using the default profile, which is “Profile 1”.

# Moving Forward

## For Developers

In some cases, the code analyzer may report errors that require complex changes to resolve. When this happens:

* Consider adjusting the severity of the error to a warning or suggestion.
* If appropriate, change it to *None* or *Silent* severity.

## For Technical Leads

* Consolidate all default `.editorconfig` files from all teams and build a new default `.editorconfig` based on these versions.
* Create new suggestive `.editorconfig` files based on the default editor config when needed, just replace `error` with `suggestion`.

Feel free to make these adjustments as needed to maintain a healthy codebase! 🚀