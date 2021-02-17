# AzatLang
My small programming language to improve my coding skills.

# Characteristic
## Types
- integer (64 bit)  
`int width 300`
- float (64 bit)  
`float acceleration 300.7`
- string  
`string name "george"`
- object (to combine other types)  
```
type Person {
    string name
    int age default 100 // sets default value of the propery
    float growth 
    float weight
}

Person Me {"Timur" 18 173 75}
Person You {
   name "Unknown"
   growth 150
   weight 300
}
```

## Built-in functions
- `print(type(s): string)` 
This function makes possible to output arguments by formatting, if you starts string line with letter "$".  
```
string name "Jo"    
print($"My name is {name}.") // >>> "My name is Jo"
print("My name is {name}." // >>> "My name is {name}."
```
