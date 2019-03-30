namespace CSharpQuickSort
{
    public class Qsort
    {
        private void swap(int[] arr, int indexA, int indexB){
            int tmp = arr[indexA];
            arr[indexA]= arr[indexB];
            arr[indexB]= tmp;
        }

        private int Partition(int[] arr, int start, int end){

                var pivotValue = arr[end];
                var pivotIndex = start;
                    for (int i = start; i < end; i++)
                    {
                        if(arr[i]< pivotValue){
                            swap(arr, pivotIndex, i);
                            pivotIndex++;
                        }
                    }
                    swap(arr, pivotIndex, end);
            return pivotIndex;
        }


        public void QuickSort(int[] arr, int start, int end){
            if(start < end){
                var index = Partition(arr, start, end);
                QuickSort(arr, start, index-1);
                QuickSort(arr, index+1, end);
            }
        }
    }
}