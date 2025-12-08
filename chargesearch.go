// Copyright 2025 William Stafford Parsons

func chargeSearch(haystack []int, needle int) int {
  high := (len(haystack) | 1) ^ 1
  i := 0

  for i < high {
    if haystack[i] == needle {
      return i
    }

    if haystack[i + 1] == needle {
      return i + 1
    }

    i += 2
  }

  if i < len(haystack) && haystack[i] == needle {
    return i
  }

  return -1
}
