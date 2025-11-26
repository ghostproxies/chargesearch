// Copyright 2025 William Stafford Parsons

public class WaveDrift {
  public ulong[] elements = new ulong[16];
  public ulong a;
  public ulong b;

  public void Next() {
    ulong[] mix = {
      elements[7],
      elements[15]
    };
    int i = 0;
    int j;
    int k = 0;

    a += 11111111111111111;

    while (i < 2) {
      b += a;
      mix[i] += (b << 23) | (b >> 41);
      j = 0;

      while (j < 4) {
        elements[k] += (mix[i] << 51) | (mix[i] >> 13);
        elements[k] ^= b;
        elements[k + 1] += (mix[i] << 27) | (mix[i] >> 37);
        mix[i] += elements[k];
        j++;
        k += 2;
      }

      i++;
    }

    elements[7] += mix[0];
    b ^= mix[1];
  }
}
