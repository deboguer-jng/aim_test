# About

You are a part of a new development team that is supplying an API (over http) that will be used by multiple dependent teams. 
It is your task to design the API and implement a minimal set of code that the other teams can use to test their integration. 
Unblocking those teams by creating the interface is more important than building a complete set of business logic.

# Features

You are tasked with designing an API for an elevator control system. Your API needs to account for the following scenarios:

- A person requests an elevator be sent to their current floor
- A person requests that they be brought to a floor
- An elevator car requests all floors that it’s current passengers are servicing (e.g. to light up the buttons that show which floors the car is going to)
- An elevator car requests the next floor it needs to service

# Getting Started

## Prerequisites

This API was built with .net 7 so you should install .net7 and .net cli as well.

## Installation

1. Clone the repository

```
  git clone https://github.com/deboguer-jng/aim_test.git
```

2. Navigate to the project directory

```
  cd your-repo
```

3. Install dependencies and run application

```
  dotnet restore
  cd AIMTest
  dotnet run
```

4. Visit application on swagger ui

```
  http://localhost:8081/swagger/index.html
```

## Usage

Currently the API is implemented in very minimal way that means it doesn't consider any elevator movement, number of passengers, and order of the requested floors as well.

You can get more detailed information for request/response bodies from swagger ui.



