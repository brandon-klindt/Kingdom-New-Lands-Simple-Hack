# Kingdom New Lands Simple Hack

Really basic hack for **Kingdom New Lands** to play around with Unity Mono Injection.

Game version v1.2.8

------

### Assembly-CSharp.dll modifications

**Game - OnLevelLoaded() : void**

Added assembly reference then called Init() to "inject" the dll every time the level loads.

```c#
Kingdom_Hack.Loader.Init();
```



**Player - coins : int** 

Created a set with the default get so that we can set the amount of coins from the player object.

```c#
public int coins
{
	get
	{
		return this._wallet.coins;
	}
	set
	{
		this._wallet.coins = value;
	}
}
```

