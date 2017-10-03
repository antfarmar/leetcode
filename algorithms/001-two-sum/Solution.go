package main

import (
	"fmt"
)

func main() {
	ans := twoSum([]int{2, 7, 11, 15}, 9)
	fmt.Println(ans)
}

// Hash Table Solution Using map
func twoSum(nums []int, target int) []int {
	m := make(map[int]int)

	for i := 0; i < len(nums); i++ {
		complement := target - nums[i]

		if v, ok := m[complement]; ok {
			return []int{v, i}
		}

		m[nums[i]] = i
	}

	//return nil; // no solution (input error)
	panic("No solution")
}
