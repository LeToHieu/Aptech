#include <stdio.h>
#include <stdlib.h>
#include <string.h>
struct Song {
    char title[30];
    char genre[30];
    unsigned int release_year;
    float price;
};
int numberOfSongs;
void printData(struct Song* songs, int numberOfSongs) {
    int i;
    printf("+--------------------------------------------------+\n");
    printf("|Song Title      |Genre     |Release Year |Price($)|\n");
    printf("+--------------------------------------------------+\n");
    for(i = 0; i < numberOfSongs; i++){
        struct Song eachSong = *(songs + i);
        printf("|%-16s|", eachSong.title);
        printf("%-10s|", eachSong.genre);
        printf("%-10d|", eachSong.release_year);
        printf("%-10f|\n", eachSong.price);
    }
}

void input(struct Song* songs) {
    int i;
    for(i = 0; i < numberOfSongs; i++){
        struct Song* eachSong = songs + i;
        printf("Song number %d : \n", i+1);
        printf("Enter title: \n"); scanf("%s", &(eachSong->title));//lat nua thu ->
        printf("Enter genre: \n"); scanf("%s", &(eachSong->genre));
        
        do {
            printf("Release Year: \n");
            scanf("%d", &(eachSong->release_year));
        }while(eachSong->release_year <= 1926
            || eachSong->release_year >= 2020);
        do {
            printf("Price: \n");
            scanf("%f", &(eachSong->price));
        }while(eachSong->price < 0.1
            || eachSong->price > 2.0);
    }
}

void sort(struct Song* songs){
    
}
/*
void analyze()
{
    struct Song* pointer1, pointer2;
    for (int i = 0; i < N; i++)
    {
        pointer1 = song + i;
        char *temp;
        temp = (char *)malloc(30 * sizeof(char));
        strcpy(temp, pointer1->genre);
        int count = 0, state = 0;
        for (int j = 0; j < i; j++)
        {
            pointer2 = song + j;
            if (strcmp(pointer2->genre, pointer1->genre) == 0)
            {
                state = 1;
                break;
            }
        }
        if (state == 1)
        {
            continue;
        }
        for (int j = i; j < N; j++)
        {
            pointer2 = song + j;
            if (strcmp(pointer2->genre, pointer1->genre) == 0)
            {
                count++;
            }
        }
        printf("\nThere are %d Song(s) of the genre '%s'", count, pointer1->genre);
        continue;
    }
}

*/
void analyze(){
    /*
    char genres[numberOfSongs][30]; //1.create an array of "genres"
    int i,j;
    //2
    for (i = 0; i < numberOfSongs; i++) {
        strcpy(genres[i], (song+i)->genre); //genres[i] = (song+i)->genre;
    }
    //3.sort ascending(alphabet)
    for (i = 0; i < numberOfSongs-1; i++) {
        for (j = i+1; j < numberOfSongs; j++) {
            if(strcmp(genres[i], genres[j]) > 0) {
                char temp[150];
                //swap genres[i] and genres[j]
                strcpy(temp, genres[i]);
                strcpy(genres[i], genres[j]);
                strcpy(genres[j], temp);
            }
        }
    }
    printf("Statistics Result: \n");
    char genreName[30];
    int count = 0;
    for (i = 0; i < numberOfSongs; i++) {
        if(i == 0) {
            strcpy(genreName, genres[i]);
            count++;
        } else if(strcmp(genres[i], genreName) != 0){
            printf("+There are %d Song(s) published by %s\n", count, genreName);
            strcpy(genreName, genres[i]);
            count = 1;
        } else if(strcmp(genres[i], genreName) == 0) {
            count++;
        }
    }
    if(numberOfSongs >0){
        printf("+There are %d Song(s) published by %s\n", count, genreName);
    }
    */
}
void find(struct Song* songs){
    float min, max;
    char genre[30];
    int i;
    printf("Find songs by genre and price\n");
    printf("Genre: \n"); scanf("%s", genre);
    printf("Min price($): \n"); scanf("%f",&min);
    printf("Max price($): \n"); scanf("%f",&max);
    //array which contains "result"
    struct Song songsResult[numberOfSongs];
    int j = 0;
    for(i = 0; i < numberOfSongs; i++) {
        struct Song *eachSong = (songs + i);
        if(eachSong->price >= min
            && eachSong->price <= max
            && strcmp(eachSong->genre, genre) == 0) {
            songsResult[j] = *eachSong;
            j++;
        }
    }
    printData(songsResult, j);
}
void save(struct Song* songs) {
    char fileName[250];
    printf("Enter file name: ");
    gets(fileName);
    while (1){
        if (gets(fileName) != NULL) break;
    }
    //FILE* file = fopen(fileName, "wb"); //wb = write binary
    FILE* file;
    file = fopen(fileName, "wb");
    if (file == NULL) {
        printf("Cannot open file for saving");
    }
    else {
        //save songs to this file, then close
        fwrite(songs, sizeof(struct Song*), numberOfSongs, file);
        fclose(file);
        printf("Data is saved successfully \n");
    }
}

void openFile(struct Song *songs) {
    char fileName[250];
    printf("Enter file name to open : "); scanf("%s", fileName);
    FILE *file = fopen(fileName,"rb"); // r for read, b for binary
    if (!file) {
        printf("Cannot open file %s\n", fileName);
    } else {
        fread(songs, sizeof(struct Song), numberOfSongs, file);
        //fread = file read
        printData(songs, numberOfSongs);
        fclose(file);
    }
}

void createMenu() {
    printf("+------------------------------------------------------------------+\n");
    printf("|                 MUSIC STORE MANAGEMENT PROGRAM                       |\n");
    printf("|1. Input |2. Sort |3. Analyze |4. Find |5. Save |6. Open |7. Exit |\n");
    printf("+------------------------------------------------------------------+\n");
    char choice;
    struct Song* songs;
    printf("Your choice:\n");
    choice = getchar();
    while(choice == '\n'){
        choice = getchar();
    }
    while(choice != '7') {
        switch(choice) {
            case '1':
                printf("How many songs ?\n"); scanf("%d", &numberOfSongs);
                songs = (struct Song*)malloc(numberOfSongs * sizeof(struct Song*));
                input(songs);
                printData(songs, numberOfSongs);
                break;
            case '2':
                if(songs != NULL) {
                    sort(songs);
                }
                break;
            case '3':
                analyze();
                break;
            case '4':
                find(songs);
                break;
            case '5':
                save(songs);
                break;
            case '6':
                openFile(songs);
                break;
            default:
                break;
        }
        printf("Do you want to continue ?\n");
        printf("- Yes, I do. (press y, Y)\n");
        printf("- No, I don't. (press n, N\n");
        printf("- Please clear the screen ! (press c, C)\n");
        printf("Your choice:\n");
        choice = getchar();
        while(choice == '\n'){
            choice = getchar();
        }
        if(choice == 'n' || choice == 'N') {
            printf("Program ended...\n");
            break;
        } else if(choice == 'c' || choice == 'C') {
            system("@cls||clear");
        }

    }

}
int main() {
    createMenu();
}




