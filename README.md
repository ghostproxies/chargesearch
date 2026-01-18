# WaveDrift

[![WaveDrift](https://repository-images.githubusercontent.com/1104441643/29dfc4cf-3247-4d0e-b848-112bd4fd9629)](https://github.com/ghostproxies/wavedrift)

## Table of Contents

- [Introduction](https://github.com/ghostproxies/wavedrift?tab=readme-ov-file#introduction)
- [Author](https://github.com/ghostproxies/wavedrift?tab=readme-ov-file#author)
- [License](https://github.com/ghostproxies/wavedrift?tab=readme-ov-file#license)
- [Period](https://github.com/ghostproxies/wavedrift?tab=readme-ov-file#period)
- [Reference](https://github.com/ghostproxies/wavedrift?tab=readme-ov-file#reference)
- [Empirical Test Results](https://github.com/ghostproxies/wavedrift?tab=readme-ov-file#empirical-test-results)

## Introduction

WaveDrift is an efficient PRNG algorithm for 1024-bit output.

It's a non-cryptographic PRNG that isn't intended for cryptographic applications.

It's intended to replace SHISHUA with faster speed, similar empirical test results and the same output size.

Further analysis is pending.

## Author

WaveDrift was created by [William Stafford Parsons](https://github.com/williamstaffordparsons) as a product of [GhostProxies](https://ghostproxies.com).

## License

WaveDrift is licensed with the [BSD-3-Clause](https://github.com/ghostproxies/wavedrift?tab=BSD-3-Clause-1-ov-file#readme) license.

The default phrase `the copyright holder` in the 3rd clause is replaced with `GhostProxies`.

## Period

WaveDrift has many possible deterministic sequences based on the seed.

A 2⁶⁴ minimum period in each sequence is proven by the mixed-in 2⁶⁴ equidistributed sequence, although the probable period is closer to the 2¹⁰²⁴ state capacity.

## Reference

### C Implementation

[wavedrift.c](https://github.com/ghostproxies/wavedrift/blob/master/wavedrift.c)

The `wavedrift` function modifies the state in a `struct wavedrift_state` instance to generate 16 pseudorandom `uint64_t` integers in the `elements` array.

Each state variable (`a`, `b`, and the entire `elements` array) in a `struct wavedrift_state` instance must be seeded, preferably with random values.

It requires the `stdint.h` header to define a 64-bit, unsigned integral type for `uint64_t`.

### C# Implementation

[wavedrift.cs](https://github.com/ghostproxies/wavedrift/blob/master/wavedrift.cs)

The `Next` function modifies the state in a `WaveDrift` instance to generate 16 pseudorandom `ulong` integers in the `elements` array.

Each state variable (`a`, `b` and the entire `elements` array) in a `WaveDrift` instance should be seeded with random values.

## Empirical Test Results

So far, WaveDrift passed up to a minimum of 8TB in PractRand 0.96 `stdin64`.

It's expected to pass up to a minimum of 32TB, although further testing is pending due to limited computing resources.

For reproducibility, the aforementioned test results seeded each state variable with `0`.
