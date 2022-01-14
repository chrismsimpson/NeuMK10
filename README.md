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

## Intermediate representation

Comming

## Stage 0

Currently in C#, thinking of redoing in C or C++. Input welcome.

## Neu sub-commands

### The `build` command

Build a Neu project.

Invoked via:
```
$ neu build ./path/to/some/project
```

#### The REPL

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