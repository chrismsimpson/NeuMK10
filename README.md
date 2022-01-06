# Neu

The escape hatch

# What is this?

From `Tests/`:

### test01.neu

```
func main() -> Int {

    return 0
}
```

A basic function

### test02.neu

```
func main() -> Float {

    return 0.0
}
```

Returns a Float type instead of an Int, both are type checked.

## LLIR / MLIR

This project is in no way associated with LLVM project, however it is heavily influenced by it. The plan here is to have two layers of intermediate representation between the language and the machine. This design is directly taken from the LLVM project, with the plan that perhaps one day Neu may take advantage of those technologies in some meaningful way.

That said, early iterations of these IRs may not resemble their distant cousins from the LLVM project.

## Stage 0

Having vacillated over which language to start with and in my indecision have settled at two:
- C# - ¯\\\_(ツ)\_/¯
- C - For the academics. No real plan to complete this. I have some opinions (don't we all) about things like treating char strictly like a byte and how UTF-8 ought be handled. Contributions definitely welcome here. Neu Mks 4 - 9 are all in C, and I have yet to rationalise down that code into this repo.

## Neu sub-commands

### The `build` command

Build a Neu project.

Invoked via:
```
$ neu build ./path/to/some/project
```

### The `eval` command

Evaluate a source file.

Invoked via: 
```
$ neu ./path/to/some/source/file.neu
```

**TODO:** Enable running by either building/compiling first or REPL mode.

#### `interactive`

An interactive mode read edit print loop (REPL).

Invoked via: 
```
$ neu
```

#### `tests`

Run the test suite.

### 

## Disclaimer

I have no idea what I am doing.