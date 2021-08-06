# Coalesce Extension Poc
This project is just a PoC to demonstrate a convenient way to check if a variable is null and return a specified default value if it is.

There's a special treatment for strings. If the variable is a string and it's null or white space, the informed default value will be returned instead of the current one.