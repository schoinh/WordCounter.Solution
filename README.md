# Word Counter

#### _A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence - July 26, 2019_

#### _By **Na Hyung Choi**_

## Description

DETAILED DESCRIPTION

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Checks whether input is valid (1 word; 1 sentence)** | which milk; I like milk | Invalid Input |
| **Checks whether input is valid (no punctuation in word)** | milk?; I like milk | Invalid Input |
| **Counts matching word frequency with only 1 word in sentence** | milk; milk | 1 |
| **Counts full word matches only** | milk; milky | 0 |
| **Counts matching word frequency with multiple words in the sentence, when the word only appears once with no punctuation** | milk; I like milk | 1 |
| **Counts matching word frequency with multiple words in the sentence, when the word appears multiple times with no punctuation** | milk; I like almond milk and rice milk | 2 |
| **Counts matching word frequency with multiple words in the sentence, when the word only appears once with punctuation** | milk; I like milk. | 1 |
| **Counts matching word frequency with multiple words in the sentence, when the word appears multiple times** | milk; I like soy milk, almond milk, and oat milk. | 3 |


## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/schoinh/WordCounter.Solution.git
    ```
2. Run the application
    ```
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Na Hyung with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi_**
