# Destiny-2-Interface
An interface in C# to communicate with the Bungie.Net API

## Installation

You can check out the latest releases [here](https://github.com/TheTrueHonker/Destiny-2-Interface/releases).
You can import these files into your project.

## Usage

### Querys
You can find all querys Bungie has to offer [here](https://bungie-net.github.io/multi/index.html)
For example if you want to search for user-informations only by the display name, you search for the query in the [Bungie.Net API](https://bungie-net.github.io/multi/index.html).
In this example it would be this static function:
```
Destiny_2_Interface.Response.User.SearchDestinyPlayer.GetUser("[API-KEY-HERE]", "SomeDisplayName")
```

An example-code would look like this:
```
string displayName = "SomeDisplayName";
Response<UserInfoCard[]> user = SearchDestinyPlayer.GetUser("[API-KEY-HERE]", displayName);
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
