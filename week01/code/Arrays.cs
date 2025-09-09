public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    
    public static double[] MultiplesOf(double number, int length)
    {

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 1: create an array of doubles of the correct length
        double[] multiples = new double[length];

        // step 2: use a loop to fill in each position in the array with the correct multiple of the number
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // step 3: return the array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 1: create a new list to hold the rotated values
        List<int> rotated = new List<int>(new int [data.Count]);

        //step 2: loop through the original list and add the elements to the new list in the correct order
        for (int i = 0; i < data.Count; i++)
        {
            //step 3: calculate the new index for each element and add it to the new list
            int newIndex = (i + amount) % data.Count;
            //4: place the element at the new index in the new list
            rotated[newIndex] = data[i];
        }
        //5: copy the ortated value back to the original list 
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = rotated[i];
        }
      
    }
}
