


## Game executable memory addresses
Memory addresses that house various values I've managed to find.

| Address               | Desc                  
| -------------------   |----------------------    
| `077B11B8`              | Current health        
| `007B2938`              | Current KO count in stage
| `007B2958`              | Current highest chain
| `007B2944`              | Current XP gained from pouches
| `007B2948`              | Current XP gained from kills

### Officer stat locations

#### Zhao Yun
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3D08`              | XP
| `007B3D00`              | Officer title
| `007B3D04`              | Level
| `007B3CF8`              | Stat weighting
| `007B3CFC`              | Equipped outfit

#### Guan Yu
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3DB0`              | XP
| `007B3DB4`              | Kills
| `007B3DA8`              | Officer title
| `007B3DAC`              | Level
| `007B3DA0`              | Stat weighting
| `007B3DA4`              | Equipped outfit

#### Zhang Fei
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3E58`              | XP
| `007B3E5C`              | Kills
| `007B3E50`              | Officer title
| `007B3E54`              | Level
| `007B3E48`              | Stat weighting
| `007B3E4C`              | Equipped outfit

#### Xiahou Dun
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3678`              | XP
| `007B3670`              | Officer title
| `007B3674`              | Level
| `007B3668`              | Stat weighting
| `007B366C`              | Equipped outfit

#### Dian Wei
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3720`              | XP
| `007B3724`              | Kills
| `007B3718`              | Officer title
| `007B371C`              | Level
| `007B3710`              | Stat weighting
| `007B3714`              | Equipped outfit

#### Sima Yi
| Address               | Desc                  
| -------------------   |----------------------    
| `007B37C8`              | XP
| `007B37CC`              | Kills
| `007B37C0`              | Officer title
| `007B37C4`              | Level
| `007B37B8`              | Stat weighting
| `007B37BC`              | Equipped outfit

#### Zhou Yu
| Address               | Desc                  
| -------------------   |----------------------    
| `007B39C0`              | XP
| `007B39B8`              | Officer title
| `007B39BC`              | Level
| `007B39B0`             | Stat weighting
| `007B39B4`              | Equipped outfit

#### Lu Xun
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3A68`              | XP
| `007B3A6C`              | Kills
| `007B3A60`              | Officer title
| `007B3A64`              | Level
| `007B3A58`              | Stat weighting
| `007B3A5C`              | Equipped outfit

#### Sun Shang Xiang
| Address               | Desc                  
| -------------------   |----------------------    
| `007B3B10`             | XP
| `007B3B14`            | Kills
| `007B3B08`              | Officer title
| `007B3B0C`             | Level
| `007B3B00`             | Stat weighting
| `007B3B04`            | Equipped outfit

### Officer titles
Officer's titles seem to be linked to their Level, however editing their Level in-memory does not seem to alter their title,
or vice versa. Theres also a total of 154 titles, whereas an officer's max level is 50, so there may be multiple factors.
This title does not seem to be linked to kills, either. Maybe there's 3 different titles for each level?

Changing their XP to over the required value doesn't level them up until getting a kill in-game.
Changing their level in-memory does result in their stats being altered according to the `weighting` of the character - another stat that the game keeps track of.

| Title value			| Text
| ------------------	| -----------------
`00`					| Lt. General
`01`					| Assistant General
`02`					| Field General
`03`					| Gate General
`04`					| 4th Foot General
`05`					| 3rd Foot General
`06`					| Lt. Foot General
`07`					| Foot General
`08`					| 4th Crusher General
`09`					| 3rd Crusher General
`10`					| Lt. Crusher General
`11`					| Crusher General
`12`					| 4th Guard General
`13`					| 3rd Guard General
`14`					| Lt. Guard General
`15`					| Guard General
`16`					| Winged General
`17`					| Flying General
`18`					| Lt. Support General
`19`					| Support General
`20`					| 4th Order General
`21`					| 3rd Order General
`22`					| Lt. Order General
`23`					| Order General
`24`					| 4th Slashing General
`25`					| 3rd Slashing General
`26`					| Lt. Slashing General
`27`					| Slashing General
`28`					| 4th Pacifying General
`29`					| 3rd Pacifying General
`30`					| Lt. Pacifying General
`31`					| Pacifying General
`32`					| 4th Pike General
`33`					| 3rd Pike General
`34`					| Pike General
`35`					| 4th Dignified General
`36`					| 3rd Dignified General
`37`					| Lt. Dignified General
`38`					| Dignified General
`39`					| 4th Dispatch General
`40`					| 3rd Dispatch General
`41`					| Lt. Dispatch General
`42`					| Dispatch General
`43`					| 4th Cohort General
`44`					| 3rd Cohort General
`45`					| Lt. Cohort General
`46`					| Cohort General
`47`					| Commander General
`48`					| Restoring General
`49`					| 4th Justice General
`50`					| 3rd Justice General
`51`					| Tower General
`52`					| River General
`53`					| Sea General
`54`					| Plains General
`55`					| Lt. Justice General
`56`					| Justice General
`57`					| Lt. Moral General
`58`					| Moral General
`59`					| 4th Loyal General
`60`					| 3rd Loyal General
`61`					| Lt. Loyal General
`62`					| Loyal General
`63`					| 4th Trusted General
`64`					| 3rd Trusted General
`65`					| Lt. Trusted General
`66`					| Trusted General
`67`					| 4th Spear General
`68`					| 3rd Spear General
`69`					| Lt. Spear General
`70`					| Spear General
`71`					| 4th Resolute General
`72`					| 3rd Resolute General
`73`					| 3rd Resolute General
`74`					| Lt. Resolute General
`75`					| Resolute General
`76`					| 4th Enchanter General
`77`					| 3rd Enchanter General
`78`					| Lt. Enchanter General
`79`					| Enchanter General
`80`					| 4th Assault General
`81`					| 3rd Assault General
`82`					| Lt. Assault General
`83`					| Assault General
`84`					| 4th Tiger General
`85`					| 3rd Tiger General
`86`					| Lt. Tiger General
`87`					| Tiger General
`88`					| Negotiator General
`89`					| Generous General
`90`					| Right Flank General
`91`					| Ambush General
`92`					| Archer General
`93`					| Lt. Crossbow General
`94`					| Crossbow General
`95`					| Left Flank General
`96`					| Lt. Rank General
`97`					| Rank General
`98`					| Lt. File General
`99`					| File General
`100`					| Lt. Horse General
`101`					| Horse General
`102`					| Lt. Banner General
`103`					| Banner General
`104`					| Lt. Lance General
`105`					| Lance General
`106`					| Sword General
`107`					| Guardian General
`108`					| Crane General
`109`					| Stallion General
`110`					| Garrison General
`111`					| Escort General
`112`					| Commandant General
`113`					| Warden General
`114`					| Distinguished General
`115`					| Capital General
`116`					| Tiger's Fangs General
`117`					| Rising Dragon General
`118`					| 4th Tranquil General
`119`					| 3rd Tranquil General
`120`					| 3rd Tranquil General
`121`					| Tranquil General
`122`					| Peacemaker General
`123`					| Peacekeeper General
`124`					| Crown General
`125`					| 4th Elite General
`126`					| 3rd Elite General
`127`					| Lt. Elite General
`128`					| Elite General
`129`					| Master General
`130`					| Rear General
`131`					| Front General
`132`					| General of the Right
`133`					| General of the Left
`134`					| 4th North General
`135`					| 4th West General
`136`					| 4th South General
`137`					| 4th East General
`138`					| 3rd North General
`139`					| 3rd West General
`140`					| 3rd South General
`141`					| 3rd East General
`142`					| Lt. North General
`143`					| Lt. West General
`144`					| Lt. South General
`145`					| Lt. East General
`146`					| North General
`147`					| West General
`148`					| South General
`149`					| East General
`150`					| Perimeter General
`151`					| Chariot General
`152`					| Cavalier General
`153`					| Grand General
`154`					| Lord General

#### Title tracking

Tracking two different officer's titles as they level up. Both started at level 1. 

| Officer	| Lvl 3				| Lvl 4				| Lvl 5					| Lvl 6					| Lvl 7
| -----		| -----				| -----				| -----					| -----					| -----
Yuan Shao	| Field General		| Gate General		| Lt. Foot General		| 4th Crusher General	|  3rd Guard General
Guan Ping	| Field General		| Gate General		| Lt. Crusher General	| 3rd Guard General		|  Lt. Guard General


### Stat weighting

This value affects the distribution of the officer's stats: `Life`, `Musou`, `Attack`, and `Defense`. Strangley it also affects the total
points used to distribute these values, i.e. a value of `05` gives a total of 1,079 points to distibute between these four stats, whereas a value of
`12` gives 1,105. This value was tested using a base level 1 Zhuge Liang.

Weighting = Individual stat value / Total points to distribute

| Value	| Weights
| ----	| ----------
| `00`	|	<p> **1,105 Points** <br> 0.24 Life <br> 0.24 Musou <br> 0.24 Attack <br> 0.25 Defense </p>
| `01`	|	<p> **1,111 Points** <br> 0.25 Life <br> 0.22 Musou <br> 0.25 Attack <br> 0.25 Defense </p>
| `02`	|	<p> **1,056 Points** <br> 0.24 Life <br> 0.28 Musou <br> 0.23 Attack <br> 0.24 Defense </p>
| `03`	|	<p> **1,103 Points** <br> 0.24 Life <br> 0.24 Musou <br> 0.24 Attack <br> 0.26 Defense </p>
| `04`	|	<p> **1,073 Points** <br> 0.24 Life <br> 0.26 Musou <br> 0.24 Attack <br> 0.24 Defense </p>
| `05`	|	<p> **1,079 Points** <br> 0.24 Life <br> 0.26 Musou <br> 0.24 Attack <br> 0.24 Defense </p>
| `06`	|	<p> **1,059 Points** <br> 0.24 Life <br> 0.27 Musou <br> 0.24 Attack <br> 0.24 Defense </p>
| `07`	|	<p> **1,018 Points** <br> 0.23 Life <br> 0.27 Musou <br> 0.24 Attack <br> 0.24 Defense </p>
| `08`	|	<p> **1,093 Points** <br> 0.24 Life <br> 0.24 Musou <br> 0.26 Attack <br> 0.24 Defense </p>
| `09`	|	<p> **1,090 Points** <br> 0.23 Life <br> 0.23 Musou <br> 0.25 Attack <br> 0.26 Defense </p>
| `10`	|	<p> **1,119 Points** <br> 0.24 Life <br> 0.24 Musou <br> 0.24 Attack <br> 0.25 Defense </p>
| `11`	|	<p> **1,119 Points** <br> 0.25 Life <br> 0.23 Musou <br> 0.26 Attack <br> 0.25 Defense </p>
| `12`	|	<p> **1,105 Points** <br> 0.25 Life <br> 0.22 Musou <br> 0.26 Attack <br> 0.24 Defense </p>

Using the same `weighting` value, I compared Zhuge Liang (lvl 1) and Zhao Yun's (lvl 47) stat distribution:

| Value	| Zhuge Liang weights	| Zhao Yun weights	| Zhuge Liang values	| Zhao Yun values
| ----	| ----------			| ------			| ------				| ------
| `02`	| <p> **1,056 Points** <br> 0.24 Life <br> 0.28 Musou <br> 0.23 Attack <br> 0.24 Defense </p>	|	<p> **3,654 Points** <br> 0.24 Life <br> 0.25 Musou <br> 0.24 Attack <br> 0.25 Defense </p>	| <p> 254 Life <br> **296 Musou** <br> 248 Attack <br> 258 Defense </p>	| <p> 896 Life <br> **938 Musou** <br> 900 Attack <br> 920 Defense </p>

The percentages are different, however the raw values show that both officers have the same most-favourable stat when their values are set to `02` - **Musou**.


When testing/comparing Yuan Shao and Guan Ping's titles as they levelled up, both of their `weighting` values were set to 33.
I got Yuan Shao to level 7, then the game autosaved upon finishing the stage. When I returned to camp, I saw that Yuan Shao was back to level 4. So I checked Guan Ping, and saw this:

![Guan Ping](https://github.com/cnopt/DW6-reverse-engineering/blob/master/Screenshot_227.png?raw=true)

He's using Yuan Shao's sword. And he's now level 7.

His weapon inventory is also full of Yuan Shao's swords:

![Guan Ping](https://github.com/cnopt/DW6-reverse-engineering/blob/master/Screenshot_228.png?raw=true)

His skill tree is also all kinds of fucked up. It seems to be completely random, as Yuan Shao didn't have any of these skills unlocked,
and certainly none of the final skills towards the right-hand side.

![Guan Ping](https://github.com/cnopt/DW6-reverse-engineering/blob/master/Screenshot_229.png?raw=true)

