//*****************************************************************************
//** 2452. Words Within Two Edits of Dictionary                     leetcode **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
char** twoEditWords(char** queries, int queriesSize, char** dictionary, int dictionarySize, int* returnSize) {
    int i;
    int j;
    int k;
    
    int len = strlen(queries[0]);
    
    char** retval = (char**)malloc(sizeof(char*) * queriesSize);
    int count = 0;
    
    for (i = 0; i < queriesSize; i++)
    {
        for (j = 0; j < dictionarySize; j++)
        {
            int diff = 0;
            
            for (k = 0; k < len; k++)
            {
                if (queries[i][k] != dictionary[j][k])
                {
                    diff++;
                    if (diff > 2)
                    {
                        break;
                    }
                }
            }
            
            if (diff <= 2)
            {
                retval[count++] = queries[i];
                break;
            }
        }
    }
    
    *returnSize = count;
    return retval;
}