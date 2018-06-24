#include <time.h>                                       //header for date and time operations
#include <stdio.h>                                      //header for standard I/O operations
#include <stdlib.h>                                     //header for maths computations, string handling, I/O processing and memory allocation
int main(){
    int level, start, c, n;     // the start of the help-continue sections, the level selector, the no' of rounds and random line of the word
    int counter = 0;            // score of the game
    int rounds = 1;                  //round of the game, should finish on 20 rounds of the game
    char *fdocu;                // name of file to open, should be easy, medium or hard difficulty
    char *word = "";            // the actual word
    char *anagram = "";         // anagram of the word-  Outputted
    char *tok = "";             // the divider of the anagram and actual word
    char line [60];             // the whole line of the file
    char ans[30];               // the answer they gave
    char read_word[1000];             // the words that they got wrong outputted
    FILE *file_wrong_write = fopen("wrong_words.txt","w");      //writing the wrong words to this file
    FILE *file_wrong_read = fopen("wrong_words.txt","r");       //reading the wrong words to this file

    printf("Welcome to the anagram game!");                                                     // Welcome
    printf("\nPress 1 to continue -- Press 2 for help -- Press 3 to exit: ");                   //outputs options to do
    scanf("%d",&start);                                                                         //select options
    if(start == 2){                                                                                 // if number chosen is 2
        printf("\nHELP");
        printf("\nFirstly you must select the level of game by pressing either 1,2 or 3.");
        printf("\nThe word will be outputted as an anagram. Type in the scrambled word.");      //List of HELP information
        printf("\nIt will then tell you if it is right or wrong. It'll do this 19 more times.");
        printf("\nOnce completed a score will be given and the actual answers of wrong answers \n");}
    if(start == 3){                                                                            //if number chosen is 3
        exit(0);}                                                                              // EXIT the code or stops running

    printf("\nChoose Difficulty -- Easy (1), Medium (2) or Hard (3): ");        //choose difficulty
    scanf("%d",&level);                                                         //input for the difficulty of the game
    if(level == 1){                                                             //if level 1 selected
        printf("Easy Difficulty Selected\n");                                       //easy selected
        fdocu="easy.txt";}                                                          //opens easy.txt file of words
    if(level == 2){                                                             //if level 2 selected
        printf("\nMedium Difficulty Selected");                                     //medium selected
        fdocu = "medium.txt";}                                                       //opens medium.txt file of words
    if(level == 3){                                                             //if level 3 selected
        printf("\nHard Difficulty Selected");                                       //hard selected
        fdocu="hard.txt";}                                                           //opens hard.txt file of words

    FILE *file = fopen(fdocu, "r");             //opens the selected file name
    if (file == NULL){                          //if the file is empty
        perror (fdocu);                             // if it can't find a file it will display error
        printf("\nFile not accessed");              // display message and
        exit(0);}                                   //exit program
    else{                                               //if it does find find the file
        while(rounds <= 20 ){                                   // only does 20 rounds of the game
            rounds++;                                                // adds 1 every time the rounds starts
            srand(time(NULL));                                  //gets the seed for the random number
            n = rand() % 50 + 1;                                // Generate random numbers
            for(c=1;c<=n;c++){                                  //chooses random numbers
                fgets(line, sizeof line, file);}                //gets the words on that line number

            word = strtok(line, "|");                           //separator of the 2 words is. (|), word is the correctly spelled first word

            while(tok != NULL){                             //while there is something before the separator
                tok = strtok(NULL, "|");                        // Split each of the 2 words up
                if(tok != NULL){                            //if its actually separated
                    anagram = tok;}}                            //anagram is the second word
                if(anagram != NULL){                        //if anagram is there
                    printf("\n%s",anagram);}                    //print the anagram
                scanf("%s",ans);                            //ans is the users answer

                if (strcmp(ans,word) == 0)                                       //if the answer and word are equal
                    {printf("Words are equal\n");                                   //print that they are equal
                    counter++;}                                                  //adds 1 to the score
                else{
                    printf("Words are not equal\n");                            // else if words are not equal print they are not equal
                    fprintf(file_wrong_write,"Your answer = %s ",ans);              //writes users answer to the wrong answers file
                    fprintf(file_wrong_write,"--- Actual answer = %s ",word);       //writes actual answer to the wrong answers file
                    fprintf(file_wrong_write,"--- The Anagram = %s",anagram);}      //writes the anagram to the wrong answers file
            rewind(file);}                                                      // goes back to the start of the file, to restart the anagram
        fclose(file_wrong_write);}                                          //closes the wrong answers file

    printf("\nYour score is %d/20\n",counter);                                          //displays score
    if (!file_wrong_read){                                                              //if file can't be read
        printf("Can't output the words you got wrong as file cannot be accessed");}         //says he can't display the word
    while (fgets(read_word,1000, file_wrong_read) != NULL){                                   //while there is nothing in the file
        printf("%s",read_word);}                                                                  //prints each line of the file
    fclose(file_wrong_read);                                                            //closes the file

    reset();                                                                            // goes to reset module
}
int reset(){
    int question;                           //variable for seeing if they want to play again
    printf("\nPress 1 to play again, else press any other character to exit: ");
    scanf("%d",&question);                  //asks them if they want to play again or not
    if(question == 1){                      // if answer is 1
            printf("\n");                       // line break
            system("cls");                      //clears outputted info from the console
            main();}                            // if they do it restarts the program
    else{
        exit(0);}                           // else it ends the program
}
