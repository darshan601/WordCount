#Word Count


This Repo contains code for implementing WordCount cmd tool.

It uses four options:

example usage:

>ccwc -c test.txt   //outputs the number of bytes in a file.

>342190 test.txt


>ccwc -l test.txt   //outputs the number of lines in a file

>7145 test.txt


>ccwc -w test.txt   //outputs the number of words in a file

>58164 test.txt


>ccwc -m test.txt   //outputs the number of characters in a file

>339292 test.txt


>ccwc test.txt
 
>7145   58164  342190 test.txt


>cat test.txt | ccwc -l

>7145

