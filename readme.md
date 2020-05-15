# WhatHttpCode

Problem: I don't know about you but I can nevern remember what all the status codes mean...
Solution: I like to try and stay in my shell as much as possible, so I thought why not create a quick tool that could give me that data back

## Install Tool Globaly

```bash
dotnet build
```

```bash
dotnet pack
```

```bash
dotnet tool install --global --add-source ./nupkg WhatHttpCode
```

## Usage

### Get All HttpCodes

```bash
$> httpcodes
```

output...

```bash
Fetching Status Codes ...
100 => Continue
101 => SwitchingProtocols
102 => Processing
103 => EarlyHints
200 => OK
....
```

### Get Particular Code

```bash
$> httpcodes 300
```

output

```bash
300 => Ambiguous
```

Hope this saves you a few seconds googling ... Sorry @Google ....
