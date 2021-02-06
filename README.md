DW6 Reverse Engineering


## Game executable memory addresses
Memory addresses that house various values I've managed to find.

| Address               | Desc                  
| -------------------   |----------------------    
| 077B11B8              | Current health        
| 007B2938              | Current KO count in stage
| 007B2958              | Current highest chain
| 007B2944              | Current XP gained from pouches
| 007B2948              | Current XP gained from kills

### Officer stat locations

#### Zhao Yun
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3D08              | XP
| 007B3D00              | Officer title
| 007B3D04              | Level
| 007B3CF8              | Stat weighting
| 007B3CFC              | Equipped outfit

#### Guan Yu
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3DB0              | XP
| 007B3DB4              | Kills
| 007B3DA8              | Officer title
| 007B3DAC              | Level
| 007B3DA0              | Stat weighting
| 007B3DA4              | Equipped outfit

#### Zhang Fei
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3E58              | XP
| 007B3E5C              | Kills
| 007B3E50              | Officer title
| 007B3E54              | Level
| 007B3E48              | Stat weighting
| 007B3E4C              | Equipped outfit

#### Xiahou Dun
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3678              | XP
| 007B3670              | Officer title
| 007B3674              | Level
| 007B3668              | Stat weighting
| 007B366C              | Equipped outfit

#### Dian Wei
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3720              | XP
| 007B3724              | Kills
| 007B3718              | Officer title
| 007B371C              | Level
| 007B3710              | Stat weighting
| 007B3714              | Equipped outfit

#### Sima Yi
| Address               | Desc                  
| -------------------   |----------------------    
| 007B37C8              | XP
| 007B37CC              | Kills
| 007B37C0              | Officer title
| 007B37C4              | Level
| 007B37B8              | Stat weighting
| 007B37BC              | Equipped outfit

#### Zhou Yu
| Address               | Desc                  
| -------------------   |----------------------    
| 007B39C0              | XP
| 007B39B8              | Officer title
| 007B39BC              | Level
| 007B39B0              | Stat weighting
| 007B39B4              | Equipped outfit

#### Lu Xun
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3A68              | XP
| 007B3A6C              | Kills
| 007B3A60              | Officer title
| 007B3A64              | Level
| 007B3A58              | Stat weighting
| 007B3A5C              | Equipped outfit

#### Sun Shang Xiang
| Address               | Desc                  
| -------------------   |----------------------    
| 007B3B10              | XP
| 007B3B14              | Kills
| 007B3B08              | Officer title
| 007B3B0C              | Level
| 007B3B00              | Stat weighting
| 007B3B04              | Equipped outfit

### Officer titles
Officer's titles seem to be linked to their Level, however editing their Level in-memory does not seem to alter their title,
or vice versa. 
Changing their XP to over the required value doesn't level them up until getting a kill in-game.
Changing their level in-memory does result in their stats being altered according to the `weighting` of the character - another stat that the game keeps track of.
Changing the `weighting` in-memory does result in a live update of their stats.

| Title value			| Text
| ------------------	| -----------------
`00`					| `Lt. General`






