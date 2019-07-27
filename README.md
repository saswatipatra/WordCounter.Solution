# Word Counter

#### _A web site which will gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. - July 26 , 2019_

#### _By **Saswati Patra**_

## Description

On this web site, it will gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Enter the word and the sentence** | sentence: I'm walking with my cat. Word: cat | Output: 1|
| **Enter the word and the sentence** |sentence: I'm walking with my cAt. Word: cat  | Output: 1|
| **Enter the word and the sentence** |sentence: I'm walking with my cat in the cathedral garden. Word: cat  | Output: 1|
| **Enter the word and the sentence** |sentence: I'm walking with my cAt, and my cat is running. Word: cat  | Output: 2|

## Setup/Installation Requirements
*_Clone this repository:https://github.com/saswatipatra/WordCounter.Solution.git_*
*_Build distribution files: dotnet build_*
*_Start the file: dotnet run_*


## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#

## Support and contact details

_Please contact  Saswati with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Saswati Patra_**
