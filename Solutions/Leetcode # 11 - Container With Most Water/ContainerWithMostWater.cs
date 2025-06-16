namespace ContainerWithMostWater
{
    public class Solutions
    {
        public int MaxArea(int[] height)
        {
            int area = 0, left = 0, right = height.Length - 1;
            for (; left < right;)
            {
                area = Math.Max(area, Math.Min(height[left], height[right]) * (right - left));
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return area;
        }

        public bool Test(int[] height, int res)
            => MaxArea(height) == res;
    }
}