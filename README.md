# SecretGermanJodelNet
---

## Introduction

This library provides a .NET wrapper for the API from [SecretGermanJodel](https://www.secretgermanjodel.com). The API is only using POST requests with FormUrlEncodedContent as content. It's also neccessary to set the Origin header to https://secretgermanjodel.com.

## Endpoints
### Login
> Login using username and password  
> Returns a usertoken to authenticate a session and if this is the first login on this account
 - Route: /auth/login
 - Parameters: 
	 + username
	 + password
 - Returns:
	 + Token: string
	 + First: int

### Account Info
> Request account information of currently logged in user
- Route: /account/info
- Parameters:
	+ full
- Returns

### Jodels
> 