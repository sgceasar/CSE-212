public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than zero.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Initialize an array of size 'length'.
        // This array will hold the multiples of the given number.
        double[] multiples = new double[length];

        // Step 2: Loop through from 0 to 'length - 1'.
        // For each iteration, calculate the multiple of the 'number' by the current index + 1.
        // For example, when i = 0, multiples[0] = number * (i + 1), i.e., number * 1.
        // When i = 1, multiples[1] = number * (i + 1), i.e., number * 2, and so on.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1); // Store the multiple at index i
        }

        // Step 3: Return the array containing the multiples.
        // The function will return the array after all multiples have been calculated and stored.
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3, 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Handle the case where the amount exceeds the list length using the modulo operator.
        // If the amount is greater than the length of the list, we use amount % data.Count to ensure that we rotate 
        // within the valid range (1 to data.Count). This prevents unnecessary full rotations. For example, rotating a list 
        // of 5 elements by 5 results in no change, but rotating by 6 is the same as rotating by 1.
        int n = data.Count;
        amount = amount % n;

        // Step 2: Slice the list into two parts.
        // - The first part contains the elements from index 0 to (data.Count - amount - 1).
        // - The second part contains the last 'amount' elements of the list.
        // GetRange(n - amount, amount) extracts the last 'amount' elements.
        // GetRange(0, n - amount) extracts the first (n - amount) elements.
        var lastPart = data.GetRange(n - amount, amount); // Get the last 'amount' elements.
        var firstPart = data.GetRange(0, n - amount); // Get the first (n - amount) elements.

        // Step 3: Modify the original list by clearing it and then adding the two parts.
        // - First, clear the original list to remove all elements.
        // - Next, add the last part (from the slice) to the beginning of the list.
        // - Finally, add the first part (from the slice) after the last part.
        data.Clear(); // Clear the original list.
        data.AddRange(lastPart); // Add the last 'amount' elements to the front.
        data.AddRange(firstPart); // Add the remaining elements after the last part.
    }
}
