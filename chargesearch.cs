// Copyright 2025 William Stafford Parsons

public static int ChargeSearch(int[] haystack, int needle) {
  int high = (haystack.Length | 1) ^ 1;
  int i = 0;

  while (i < high) {
    if (haystack[i] == needle) {
      return i;
    }

    if (haystack[i + 1] == needle) {
      return i + 1;
    }

    i += 2;
  }

  if (
    i < haystack.Length &&
    haystack[i] == needle
  ) {
    return i;
  }

  return -1;
}
