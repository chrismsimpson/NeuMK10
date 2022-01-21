# Neu

The escape hatch

# What is this?

An experimental programming language. Currently, I am merely building an interpreter, but I am organising the layout of the interpreter/virtual machine much like you would a compiled C program, so that I can later add that level of interoperability. To see what you can already do with this language, have a look at the [tests](./TESTS.md).

## Intermediate representation

Coming

## Stage 0

Currently in C#, thinking of redoing in C or C++. Input welcome.

## Neu sub-commands

### The `build` command

Build a Neu project.

Invoked via:
```
$ neu build ./path/to/some/project
```

### The REPL

An interactive mode read edit print loop (REPL).

Invoked via: 
```
$ neu
```

### Interactive mode

Evaluate a source file.

Invoked via: 
```
$ neu ./path/to/some/source/file.neu
```

**TODO:** Enable running by either building/compiling first or REPL mode.

### Test Suite

Run the test suite.

Invoked via: 
```
$ neu tests
```

### 

## Disclaimer

I have no idea what I am doing.