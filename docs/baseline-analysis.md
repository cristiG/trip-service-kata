 Baseline Analysis

 1. Introduction

The Trip Service project is a legacy Python application used to practice unit testing and refactoring.

The purpose of this baseline analysis is to examine the existing source code, identify code smells, select suitable refactoring techniques, and understand the current software structure.

Before making any changes to the original code, characterization tests are written to understand and document its existing behavior.

The main objective is to improve code quality, readability, maintainability, and object-oriented design while preserving the existing behavior.

## 2. Identified Code Smells

After examining the original `tripservice.py` file, the following code smells were identified:

### 2.1 Inconsistent Naming
The methods use camelCase naming, such as `addFriend()` and `addTrip()`, instead of Python's standard snake_case naming convention.

### 2.2 Typo in Class Name
The exception class name `DependendClassCallDuringUnitTestException` contains a spelling mistake. This reduces code readability and makes the name difficult to understand.

### 2.3 Inconsistent Attribute Naming
The `User` class initializes an attribute named `self.friend`, but the `addFriend()` method uses `self.friends`. This inconsistency can cause errors.

### 2.4 Incorrect Collection Method
The `trips` attribute is initialized as a list, but the `addTrip()` method uses `.add()`, which is not a list method. Lists use `.append()` to add elements.

### 2.5 Hard-Wired Dependencies
The `getTripsByUser()` function directly calls `_getLoggedUser()` and `_findTripsByUser()`. This makes testing difficult because these dependencies are not passed into the function.

## 3. Proposed Refactoring Techniques

The following Fowler refactoring techniques are proposed to address the identified code smells:

| Code Smell | Proposed Refactoring Technique |
|---|---|
| Inconsistent Naming | Rename Method |
| Typo in Class Name | Rename Class |
| Inconsistent Attribute Naming | Rename Field |
| Incorrect Collection Method | Encapsulate Collection |
| Hard-Wired Dependencies | Parameterize Function |

### Explanation of Techniques

1. **Rename Method:** Change method names to follow Python naming conventions, such as `add_friend()` and `add_trip()`.

2. **Rename Class:** Correct the spelling mistake in the exception class name.

3. **Rename Field:** Use a consistent attribute name for the user's friends collection.

4. **Encapsulate Collection:** Control collection modifications through class methods and use the appropriate list operation.

5. **Parameterize Function:** Pass dependencies as parameters instead of directly calling hard-wired functions.

These techniques will help improve readability, maintainability, and testability while preserving the intended behavior.



## 4. Baseline Characterization Tests

Characterization tests are written before refactoring to understand and document the existing behavior of the legacy application.

The following tests have been created in `python/tests/test_tripservice.py`:

### 4.1 Test User Not Logged In
This test verifies that the application raises `UserNotLoggedInException` when no user is logged in.

### 4.2 Test Friend User Gets Trips
This test verifies that trips are returned when the logged-in user is a friend of the requested user.

### Test Execution

The tests were executed using pytest:

```bash
python -m pytest python/tests/test_tripservice.py -v
```

**Baseline Result:** 2 tests passed successfully.

These tests provide a baseline for checking that the application's behavior remains consistent during refactoring.


### 4.3 Test Non-Friend User Gets Empty Trips
This test verifies that an empty list is returned when the logged-in user is not a friend of the requested user.