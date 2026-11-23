legacycode-hands-on-session
===========================

Kata for a legacy code hands-on session. The objective is to write tests and refactor the given legacy code.
 Group Information

Project: Trip Service Refactoring  
Course: Software Construction and Development (SCD)  
Group Number: 2

 Group Members
 1  Muhammad Bilal  SWEN241101035 
 2  Rehan Ahmed     SWEN241101010 
 3  Malik Asad      SWEN241101029
 4  Siftul Hasnain  SWEN241101047 

  Project Description

Trip Service is a legacy Python project designed for practicing unit testing and refactoring.

The project focuses on identifying code smells, writing characterization tests, and improving code structure while preserving existing behavior.

 Project Structure

- `tripservice.py` – Main Python implementation.
- `tripservice_mechanical/` – Mechanical translation of the original Java code.
- `tripservice_original.py` – Original reference implementation.
- `README.markdown` – Python project instructions.

 Setup and Run Instructions

 Requirements
- Python 3.x
- pip
- pytest

 1. Clone the Repository
```bash
git clone https://github.com/malikasadsrc901-oss/SCD-Group-2-Refactoring.git
```

 2. Install pytest
```bash
python -m pip install pytest
```

 3. Run Characterization Tests
From the project root directory, run:

```bash
python -m pytest python/tests/test_tripservice.py -v
```

 4. Run the Python Source File
```bash
python python/tripservice.py
```

**Note:** This project is a legacy-code refactoring exercise. The main purpose is to write tests and improve the code while preserving its existing behavior.