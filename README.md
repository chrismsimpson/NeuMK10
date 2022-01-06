# Neu

The escape hatch

## What is this?

From Tests/:

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

This project is in no way associated with LLVM project, however it is heavily influenced by it. The plan here is to have two layers of intermediate representation between the language and the machine. This design is directly taken from the LLVM project, with the plan that perhaps one day Neu may take advantage of those technologies at some point.

That said, early iterations of these IRs may not resemble their distant cousins from the LLVM project.

## Disclaimer

I have no idea what I am doing.