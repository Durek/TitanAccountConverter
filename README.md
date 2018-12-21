# TitanAccountConverter
##### Converts a list of steam accounts (username:password) to a [Titan](https://github.com/Marc3842h/Titan) readable format

![Screenshot](http://i.epvpimg.com/hsjIfab.png)

### Example

Input:
```
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
account:password
```
Output:
```
{'indexes':[
    {'accounts': [
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'}
    ]},
    {'accounts': [
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'}
    ]},
    {'accounts': [
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'},
        {'username': 'account','password': 'password'}
    ]}
]}
```