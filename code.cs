public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int start = 0, end = arr.Length - 1;
        while(start <= end)
        {
            int mid = start + (end - start) / 2;

            if(arr[mid] > arr[mid + 1])
            {
                // peak elemet lies in the left half
                if(arr[mid] > arr[mid - 1])
                {
                    // mid is the peak element
                    return mid;
                } else
                {
                    end = mid - 1;
                }
            } else
            {
                // peak element lies in the right half
                start = mid + 1;
            }
        }
        return -1;
    }
}
