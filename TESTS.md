# Tests

I am building a test for each new part of the language as I go.


## 00 - Runtime

```
```

An intentionally empty file. This is to test bootstrapping a parser & interpreter, without actually running anything.

Not sure exactly when this was added but you actually have two options here: a file with a `main()` function or just top level statements. When using top level statements, a source file's declarations are first executed (added to the vtable) and then each executable statement is performed on the stack. This probably needs to be refined/made progressive (e.g. all func declarations first, then var declarations etc.).


## 01 - `func main` with a return Int

```
func main() -> Int {

    return 0
}
```

Presumabily you could use this as an exit code.


## 02 - `func main` with a return Float

```
func main() -> Float {

    return 0.0
}
```

Adds a float type.


## 03 - Arithemtic

```
func foo() -> Float {
    
    // return 1 + ((2 * 3) / 4)
    
    return 1 + 2 * 3 / 4
}

foo()
```

Adds comments and infix operators with precedence.


## 04 - Variables

```
var c = 1

func foo() -> Int {

    var a = 5
    var b = 7
    return a + b + c
}

foo()
```

Adds variables and does some intentionally weird scoping/ordering of things.


## 05 - Postfix Increment

```
func main() -> Int {

    var i: Int = 0

    i++

    return i
}
```

Adds postfix operators.


## 06 - Postfix Decrement

```
func main() -> Int {

    var i: Int = 0

    i--

    return i
}
```


## 07 - Prefix Increment

```
func main() -> Int {

    var i: Int = 0

    ++i

    return i
}
```

Adds prefix operators and a way to delimit expressions when there are multiple line breaks.


## 08 - Prefix Decrement

```
func main() -> Int {

    var i: Int = 0

    --i

    return i
}
```

## 09 - True

```
func main() -> Bool {

    return true
}
```

Adds Bool types.

## 10 - False

```
func main() -> Bool {

    return false
}
```