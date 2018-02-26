/*
The PADS

Generate the following two result sets:

1- Query an alphabetically ordered list of all names in OCCUPATIONS, immediately followed by the first letter of each profession as a parenthetical (i.e.: enclosed in parentheses). For example: AnActorName(A), ADoctorName(D), AProfessorName(P), and ASingerName(S).
2- Query the number of ocurrences of each occupation in OCCUPATIONS. Sort the occurrences in ascending order, and output them in the following format: 
	There are a total of [occupation_count] [occupation]s.
where [occupation_count] is the number of occurrences of an occupation in OCCUPATIONS and [occupation] is the lowercase occupation name. If more than one Occupation has the same [occupation_count], they should be ordered alphabetically.

Note: There will be at least two entries in the table for each type of occupation.

The results of the first query are formatted to the problem description's specifications. 
The results of the second query are ascendingly ordered first by number of names corresponding to each profession (), and then alphabetically by profession (, and ).

*/

SELECT NAME + '(' + SUBSTRING(OCCUPATION,1,1) + ')'
FROM OCCUPATIONS
order by name;

SELECT 'There are a total of ' + CAST(COUNT(OCCUPATION) AS VARCHAR(MAX)) + ' ' + LOWER(OCCUPATION) + 's.'
FROM OCCUPATIONS
GROUP BY OCCUPATION
order by COUNT(OCCUPATION);