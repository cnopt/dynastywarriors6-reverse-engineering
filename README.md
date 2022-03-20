### Officers

#### IDs

Each officer has a unique `id` - changing this value has some unexpected effects that will be mentioned later in this document.

| ID		| Officer
| ------	| --------------------
``

#### Character Mashing (inc. playing as generic officers)

Probably the most popular/well-known series of hacks throughout all Dynasty Warriors games is the ability to play as generic officers.
I say this because the same way that I'll describe how to play as generic officers in this title, is almost identical to the steps
required to play as generic officers in every previous title, all the way back to DW3.

As mentioned above, each officer has an ID. Changing this `id` to a value outside of the playable officer range allows you to use
any of the hundreds of non-playable officers that appear in various battles throughout the game. As with the previous games, you can also play as
any of the 'peon' enemies, such as privates, majors, guard captains, catapult officers, archers, etc. There are some caveats, though. Their
weapon and player portrait will be determined by the officer you choose at the selection screen. Everything else can be swapped around, hence
why I call this 'mashing'.

* Their voice and lines can be swapped
* Their moveset can be swapped
* Their skill tree can be swapped

Meaning that you can essentially create your own ideal officer. Or a really stupid one.


##### Current officer id/model/name `0x007756B4`

The value of this address determines the name of the officer you're playing as, and the model. I won't list the entire range here, but
the valid values seem to go up to near the 500 mark. It seems like after around 300-350 is where they start to go from generic officers
to the peon enemies. 


##### Current voice/lines `0x00772EF8`

Changing this address changes both the voice of the officer and therefore their lines when killing an officer, capturing a base, killing X
enemies etc. I thought it was worth mentioning that this can be independantly changed, since you can get some funny results.


##### Current moveset `0x00772F00`

Also independant of the ID/model. This means you can use certain officers' weapons with other officers' movesets, for either good or weird results.
This moveset value is equivalent to the officer's ID, i.e. if you wanted to use Zhou Yu's moveset, you'd set this to a value of `5`. You'll
have his moveset, but you'll be using the weapon of the officer you chose in the selecion screen.


##### Current skill tree `0x775A0`

This doesn't typically have too much bearing on gameplay, especially if you're already using a character with good weapons and stats. 
A specific case where I found this to be very useful, though, is using the skill tree of officers that have the 'Special Start' ability.
There's only a few officers that can have this, one example being Zhang Liao. Therefore, changing the value of this address to Zhang Liao's ID 
allows you to benefit from this skill on any other character. You'll also benefit from his horse abilities too, meaning you can absolutely
blast through stages on horseback.


With all of those things in mind, here's a Peasant with Zhao Yun's Dragon Fang, using Zhou Yu's moveset, Lu Bu's voice + lines, and Zhang Liao's
skill tree (he started the stage with a Tome). 

![playing as Peasant](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/DVhKApG.png)


##### Steps

1. While at the main menu, or the stage select screen, change one of the addresses above to your desired value
2. Freeze the value in Cheat Engine by crossing the checkbox to the left of the address name/description. Without this, 
the value will be changed to the officer you select in the next screen
3. In the officer selection screen, pick the officer whose weapons + stats you'd like to use
4. Once you've loaded into the stage preparation screen, check in the 'personal' menu to see if you're using the officer you 
wanted to use. For peon enemies, their name will be blank.
5. Load in to the stage



#### Titles

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

Tracking two different officer's titles as they level up. Both started at level 1. The value does increase with the levels, but it does not exactly mirror it.
Maybe the game chooses a random title that falls in each level bracket.

| Officer	| Lvl 3				| Lvl 4				| Lvl 5					| Lvl 6					| Lvl 7
| -----		| -----				| -----				| -----					| -----					| -----
Yuan Shao	| Field General		| Gate General		| Lt. Foot General		| 4th Crusher General	|  3rd Guard General
Guan Ping	| Field General		| Gate General		| Lt. Crusher General	| 3rd Guard General		|  Lt. Guard General


#### Stat weighting

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

![Guan Ping](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_227.png)

He's using Yuan Shao's sword. And he's now level 7.

His weapon inventory is also full of Yuan Shao's swords:

![Guan Ping inventory](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_228.png)

His skill tree is also all kinds of fucked up. It seems to be completely random, as Yuan Shao didn't have any of these skills unlocked,
and certainly none of the final skills towards the right-hand side.

![Guan Ping skill tree](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_229.png)

In game, the weapon remains, but he keeps his actual halberd/trident moveset.

![Guan Ping ingame 1](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_231.png)
![Guan Ping ingame 2](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_232.png)

So maybe this is nothing to do with weighting after all. While I was testing the `weighting` value -- or that's what I thought it was -- the maximum value was 41. 
There are 41 playable characters. Maybe this value is actually a sort of `id` that's tied to the officer to contain their weapon information and level/stats.
Will have to dig deeper into whether this value is unique for all officers.

Replicated using Zhang Fei and Zhuge Liang by setting Zhang Fei's value to Zhuge Liang's value, then completing a stage. This effectively
transfers both the cumulative XP gained (i.e. their level up to now), and the XP gained from the battle, onto the receiving player - in this case Zhuge Liang.
Zhuge's weapon model was also changed, in the same way as the previous case. Reverting the values to their default state and completing a stage *does* mean the officers can go back to being able to level up
their own stats, however does **not** seem to reverse the weapon model+inventory transfer. 

![Zhuge Liang](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_233.png)

Setting every officer's value to `10`, the same as Zhao Yun's, then completing a stage with him, did **not** result in the same effect happening, like I thought it would.


#### Skills

Each officer has a unique skill tree, and not all of them have the same overall amount of skills to unlock. By level 50,
or sooner, an officer will have all skills unlocked. The game keeps track of the number of skills unlocked in the officer's
stat block, however it does so with a fucking massive 64-bit number. It's actually the first value to appear in
a block, since everything before it is zero'd out. It's most recognisable in a maxed-out officer, since
in Hex it'll look like this:

![maxed out skill tree hex](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_13.png)

Each of the 6 bytes is at a value of `255`. With a level 1 officer, the simplest method to achieve a full skill tree
is to set each of these bytes to `FF`. Individually, this seems to unlock a sort of 'layer' each time. I'm still unsure
about how to unlock *individual* skills within the tree, as there  doesn't seem to be a pattern.




#### Unlocking officers

I compared two	`save.dat` files - one before unlocking an officer, and the second after unlocking Xu Huang. I was hoping to find a simple change from a `00` i.e. not unlocked false,
to a `01` somewhere. Among other changes, presumably because the game keeps track of the objectives necessary to unlock each officer, there was indeed a simple `00` -> `01` change at address `1874`.

![Officer unlocked address](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_238.png)

Changing this value back to 00, then reloading the save in-game through the options menu removed Xu Huang from the playable characters list.
Looking around this data, there are a lot of repeating values and 0's throughout each block. This, combined with the fact that we know
each officer's data is comprised of 168 bytes, led me to select the previous 168 bytes and see what value appears.

![Officer unlocked address](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_237.png)

It's `01`. Meaning this is clearly also an officer (one that's been unlocked). In this case it's Xiahou Yuan, since he appears before Xu Huang.

Moving forward another 168 bytes *after* Xu Huang's 'unlock status' would theoretically then put us at the next officer's 'unlock status' address. That value
is currently at `00`, since that officer hasn't been unlocked yet. Let's flip it to `01` and reload the save:

![Zhang He now unlocked](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_239.png)

It worked. Apparently this byte is all that determines whether a character is playable, it doesn't matter if the objective to unlock them was actually met.

Again, advancing forward 168 bytes into the next 'block' and flipping the value to `01` allows us to unlock every officer in the game,
without doing any of the required objectives.


#### Officer stat block layout/example/guide

Officer data is structured in the following order:

1. Skills tree *(7 bytes)*
2. Weapon data/storage *(128 bytes total, 8 weapons)*
	1. Weapon id *(4 bytes)*
	2. Damage offset *(4 bytes)*
	3. Element *(4 bytes)*
	4. Skills *(4 bytes)*
3. Officer id *(4 bytes)*
4. Equipped outfit *(4 bytes)*
5. Title *(4 bytes)*
6. Level *(4 bytes)*
7. XP *(4 bytes)*
8. Kills *(4 bytes)*
9. Unlock status *(4 bytes)*

To illustrate, here's the stat block of base-level Lu Bu. No skills, no XP, no kills, no weapons, etc. Since everything
is full of `00`'s, it can be hard to find specific officers, without a definitive value that's probably unique (such as their XP).

![lu bu hex stat block](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_16.png)

Even if this scenario, when it's difficult to find a specific officer, there are some values that can be used
to instantly determine what you're looking at. First, of course, is the officer `id`. Second, are their `weapon id`'s.
This is actually easier, since there will either be a sequence of 8 of them in a row, or *one* unique value followed by
a sequence of `AE`'s, since this is the value the game uses to represent a blank weapon. If you've not used the officer before,
or they only have a single weapon, look for those.

In the above screenshot, Lu Bu's is identificable by the `id` being `10` (16), and his first weapon having an `id` of
`30` (49). Using the weapon id table we know that's the Sky Piercer.



---

### Warhorses

Horses are stored in much the same way officers are. Their XP and individual stats are all kept track of, however it seems as though their
data is around 60 bytes each, since there are less variables to keep track of.

![Warhorse hex values](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_240.png)

That's how they appear in the `save.dat` file. I have 4 maxed out horses, so their XP address holds the value `88 13` - 5000.
Another easy one to figure out is the `Speed`, `Jump`, `Destruction`, and `Attack` values. They come 6 bytes after the XP value, since
in this screenshot they are all at `F4 01` - 500.
Each of these values can be adjusted in-game via the memory addresses I've found in the executable, or here inside this save file.

![Warhorse stats changed](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_241.png)

Ingame, using Red Hare with these values doesn't affect the speed of the horse, so there must be a minimum speed + an offset from the `Speed` stat,
however the `Destruction` value being so low means that the horse gets stuck on even the peon enemies:

![Red Hare troubles](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/horse_des_1.gif)

Trying the opposite end of the spectrum:

![Red Hare troubles](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_242.png)

Sadly this doesn't result in a 300mph horse. In fact, it doesn't alter any of the stats in any meaningful way above `500`.


#### Warhorse names

Oh boy, warhorses also have their own pool of names. Two of them. And their own titles. And their own two-part descriptions. All of which are randomly generated.
Their `prefix` and `suffix` values are stored right next to eachother.

##### Prefixes
| Value		| Name			| Value		| Name		| Value		| Name
| --------	| -----------	| --------	| --------- | --------	| --------	
`01`		| Bay 			| `12`	    | Dawn 		| `23`	    | Ginger
`02`		| Chestnut 		| `13`	    | Dusk 		| `24`	    | Royal
`03`		| Grey 		    | `14`	    | Evening 	| `25`	    | Cinnamon
`04`		| Blue 		    | `15`	    | Harvest 	| `26`	    | Saffron
`05`		| Red 		    | `16`	    | Brindle 	| `27`	    | Sparkling
`06`		| Dapple 		| `17`	    | Quiet 	| `28`	    | Valiant
`07`		| Savage 		| `18`	    | Eastern 	| `29`	    | Brave
`08`		| Roan 		    | `19`	    | Western 	| `30`	    | Ultimate
`09`		| Chrome 		| `20`	    | Southern 	| `31`	    | Cosmic
`10`		| Dun 		    | `21`	    | Northern 	|    	    | 
`11`		| Pinto 		| `22`	    | Phantom 	|    	    | 


##### Suffixes
| Value		| Name			| Value		| Name		| Value		| Name
| --------	| -----------	| --------	| --------- | --------	| --------	
`01`		| Cloud 		| `12`	    | Bull 		| `23`	    | Sprinter
`02`		| Mist 			| `13`	    | Stone 	| `24`	    | Striker
`03`		| Dream 		| `14`	    | Boulder 	| `25`	    | Emperor
`04`		| Shadow 		| `15`	    | Beauty 	| `26`	    | King
`05`		| Fang 		    | `16`	    | Warlord 	| `27`	    | Phoenix
`06`		| Song 			| `17`	    | Sun 		| `28`	    | Titan
`07`		| Fox 			| `18`	    | Moon 		| `29`	    | Wave
`08`		| Leopard 		| `19`	    | Comet 	| `30`	    | Zephyr
`09`		| Cat 			| `20`	    | Dasher 	| `31`	    | Warrior
`10`		| Rat 		    | `21`	    | Eagle 	|    	    | 
`11`		| Tiger 		| `22`	    | Devil 	|    	    | 

The system does lead to some interesting/cool names, even when randomly generated, such as Cosmic Titan, or Valiant Emperor.
If you want just one of these names without the prefix or suffix, you can put either of the values above `31` and it'll be blank.

#### Models

| #			| Model																				| #			| Model																						| #			| Model																					| #			| Model
| --------	| -----------																		| --------	| ---------																				| --------	| --------																				| -------	| ---------
`01`		| ![h1](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h1.png)| `05`	    | ![h5](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h5.png) 	| `09`	    | ![h9](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h9.png)	| `13`		| ![h13](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h13.png)
`02`		| ![h2](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h2.png)| `06`	    | ![h6](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h6.png) 	| `10`	    | ![h10](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h10.png)	| `14`		| ![h14](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h14.png)
`03`		| ![h3](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h3.png)| `07`	    | ![h7](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h7.png) 	| `11`	    | ![h11](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h11.png)	| `15`		| ![h15](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h15.png)
`04`		| ![h4](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h4.png)| `08`	    | ![h8](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h8.png) 	| `12`	    | ![h12](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/h12.png)	| 

#### Elements

A horse has the chance to have an elemental ability tied to it, but there's only 3 of them: `Fire`, `Lightning`, and `Ice`.
Each of these elements has a chance to bind to any officers/peons you run over with your horse. But nothing crazy.

#### Description(s)

A horse's description in this game consists of two parts - their **eyes** and their **physique**. That's all it comes down to.
These are two different values in memory, meaning, like their names, they can be mix and matched. These descriptors tell you about the horse's
ability in combat, and it's speed. But I imagine its a very loose fitting system.

In the community, it's widely known that in order to obtain Red Hare, you need to find a red horse with these descriptors:

1. Eyes consider the world
2. Has a heavenly physique 

Once you've got a horse with these descriptors, and raised it to level 5, it's model will transform to that of Red Hare - armour and all.
However, according to [this](https://www.xboxachievements.com/forum/topic/50264-red-hare/) post, it's not a *true* red hare unless
it also has the "Wind Spirit" skill, since that makes its speed that of the true Red Hare.

##### Eyes
| Value				| Description
| -----				| -----
`00`				| Gaze into the distance
`05`				| Miss nothing
`07`				| View the world in clarity
`15`				| **Consider the world**

##### Physique
| Value				| Description
| -----				| -----
`00`				| Harbors untold power
`01`				| Has a well-balanced physique
`02`				| Has a superior physique
`03`				| **Has a heavenly physique**




#### Skills

A horse can come with a set of 1-4 skills. Or no skills. This too is determined by a single value in the horse's save data block.
It follows a pattern/logic, in that the skills stack on top eachother and then reset with a new 'base' skill.
I'll list all of the skills a horse can have here:

| Skill								| Description
| --------							| -----------	
*Values between 0-15 shuffle these skills:*
Arrow Dance							| Repels arrows when running
Find Saddle							| Acquire a horse after each victory
Find Weapon							| Acquire a weapon after each victory
Musou Spirit						| Musou guage gradually refills while on horse
*Values between 16-31 shuffle these skills:*
Renbu Gait							| Renbu gauge doesn't deplete while on horse
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
*Values between 32-63 shuffle these skills:*
Winged Hoof							| Damage enemies with a shockwave when landing from a big jump
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
Renbu Gait							| ''
*Values between 64-127 shuffle these skills:*
Jagged Hoof							| Increased damage when running over enemies
Winged Hoof							| ''
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
Renbu Gait							| ''
*Values between 128-255 shuffle these skills:*
Steel Hoof							| Able to charge into large crowds
Jagged Hoof							| ''
Winged Hoof							| ''
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
Renbu Gait							| ''
*Values between 256-511 shuffle these skills:*
Water Spirit						| Able to swim quickly, regardless of current
Steel Hoof							| ''
Jagged Hoof							| ''
Winged Hoof							| ''
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
Renbu Gait							| ''
*Values between 512-1023 shuffle these skills:*
Stone Spirit						| Able to withstand heavy damage
Water Spirit						| ''
Steel Hoof							| ''
Jagged Hoof							| ''
Winged Hoof							| ''
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
Renbu Gait							| ''
*Values between 1024-2056 shuffle these skills:*
**Wind Spirit**						| **Able to run as fast as Red Hare**
Stone Spirit						| ''
Water Spirit						| ''
Steel Hoof							| ''
Jagged Hoof							| ''
Winged Hoof							| ''
Arrow Dance							| ''
Find Saddle							| ''
Find Weapon							| ''
Musou Spirit						| ''
Renbu Gait							| ''

In other words, 
> with each doubling of the value, a new skill is introduced and the 'pool' is  increased, with 
> the horse's random selection of 1-4 abilities now including this new skill.

With the later abilities, such as `Wind Spirit`, this does make getting a horse with a specific set of skills
quite difficult. Even modifying the memory address in real-time, it took ages for me to go through the values sequentially to find
one that included both `Wind Spirit` and `Steel Hoof`. Imagine how long it'd take if you were to farm horses legitimately.

With this information, it's possible to define your own *Ultimate Red Hare*:

![Red Hare](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_243.png)


---

### Challenge Mode

#### Leaderboards

The 'personal best' screen shows a list of the top 10 best scores in that specific challenge. This data is also stored.
Specifically, the total score, and some sort of ID number for the officer who got the score.

I set a new high score of 1565 in Rampage with Lu Bu, then compared the save files.

Previously, the record was 1500 by Lu Bu also: <br>
![Rampage high score](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_1.png)

After getting 1565, this value changed, but the next byte after was still at `10 00`: <br>
![Rampage high score](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_2.png)

I changed the byte of the officer now in second position (i.e. Lu Bu) from `10` to `17`, and Xu Zhu appeared:
![Rampage high score](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_3.png)

Just to experiment, I put this 'id' to a stupid number, in this case 147:
![Rampage high score](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_4.png) <br>
*Who the hell is Jiang Qin. Must be a generic officer.*


Interestingly, in 7th position is Zhang Fei. After his high score is `0C` - 16. Since I'm thinking this looks like
some sort of unique identifier, I'll check what his value for 'weighting' is set to. Turns out that's also 16.

To test, I'll change some of these leaderboard id's to ones I already know are assigned to specific officers:
* Guan Ping is `33`
* Yuan Shao is `36`
* Lui Bei is `14`
* Dian Wei is `5`
* Lu Xun is	`7`

![Rampage high score changed](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_5.png)

Weird. The first three officers are correct, but Zhou Yu and Sun Shang Xiang appear where Dian Wei and Lu Xun should appear.
I checked their save data and it doesn't seem like I got a value wrong. I'll give Zhao Yun a `weighting`/`id` value of `05` and
complete a stage in order to achieve the 'stat transfer' trick described above.

![Rampage high score changed](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_6.png)

Yep, Zhou Yu now has Zhao Yun's spear. And Dian Wei is unaffected. Next, I changed Zhao Yun's `weighting`/`id` to `07` and did the same.

![Rampage high score changed](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_7.png)

SSX now also has his spear. And Lu Xun is unaffected. Seems like I definitely got something wrong.

In order to find out Lu Xun and Dian Wei's **true** `id`'s, I could check the leaderboards and see if they appear on any of them.

![Gauntlet high score changed](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_8.png)

There's Lu Xun, in 5th position in Gauntlet. In the save data for this challenge, his `id` appears as `06`: <br>

![Rampage high score changed](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_9.png)

But in his block of stats where his XP/level etc. is stored, there is absolutely no 6. Only 7. I've previously downloaded a 100% completed save
with all characters maxed out in order to compare the two `save.dat` files, so I diff'd my current save and the completed save,
then navigated to Lu Xun's block:

![Lu Xun stats block](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_10.png)

To ~~double~~ ~~triple~~ quadruple check, I deleted my save and started fresh, and sure enough the value was set back to `06`. 
I must have been fucking around with what I thought was the stat weighting, and accidentally saved the game at some point.

---

### Weapons

Weapons are stored in blocks of 16 bytes, before each character's general stats. It consists of the following:

* `weapon id` - a unique identifier for the weapon that the officer wields. This value is specific to even the level of
the weapon, i.e. Zhao Yun's first-level weapon 'Dragon Spike' is a different value to Zhao Yun's 'Dragon Fang'.
* `damage` - This *isn't* a direct numerical value for the weapon's damage. Instead, it works as a sort of 'bracket' for the 
damage to fall into. It is affected by the `id`, in that a lower-tier weapon will have reduced damage, even while value remains the same.
* `element` - Can be Fire, Ice, or Lightning.
* `skills` - A set of 1-4 abilities the weapon has.

#### Weapon IDs

This table is pretty interesting, since you can pinpoint the exact moment they stopped giving a shit about different weapon models
for each of the tiers. **From Xu Zhu onwards**, the first, second, and third weapons all share the same model.

| Value		| Name							| Officer				| Image																													| Value		| Name					| Officer			| Image
|----------	| -------------------			| -------------------	| ----------------																										| -------	| ----------------		| -------------		| ---------------------
`00`		| Rock Crusher					| Xiahou Dun			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xiahoudun-1.png)					| `68`		| Chaos					| Cao Pi			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caopi-2.png)
`01`		| Wave Breaker					| Xiahou Dun			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xiahoudun-3.png)					| `69`		| Rage Trident			| Taishi Ci			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/taishici-1.png)
`02`		| Thundersmash					| Xiahou Dun			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xiahoudun-2.png)					| `70`		| Savage Trident		| Taishi Ci			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/taishici-3.png)
`03`		| Violent Soul Flail			| Dian Wei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/dianwei-1.png)					| `71`		| Tsunami Trident		| Taishi Ci			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/taishici-2.png)
`04`		| Lion's Head Flail				| Dian Wei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/dianwei-3.png)					| `72`		| Valor					| Lu Meng			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lumeng-1.png)
`05`		| Beserker Flail				| Dian Wei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/dianwei-2.png)					| `73`		| Spirit				| Lu Meng			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lumeng-3.png)
`06`		| Eradication Claws				| Sima Ye				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/simaye-1.png) 					| `74`		| Courage				| Lu Meng			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lumeng-2.png)
`07`		| Anguish Claws					| Sima Ye				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/simaye-3.png)						| `75`		| River Slicer			| Huang Guai		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/huangguai-1.png)
`08`		| Necrosis Claws				| Sima Ye				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/simaye-2.png)						| `76`		| Mountain Breaker		| Huang Guai		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/huangguai-3.png)
`09`		| Twin Vipers					| Zhange Liao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangliao-1.png)					| `77`		| Sky Lasher			| Huang Guai		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/huangguai-2.png)
`10`		| Twin Dragons					| Zhange Liao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangliao-3.png)					| `78`		| Flashstrike			| Zhou Tai			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhoutai-1.png)
`11`		| Twin Eagles					| Zhange Liao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangliao-2.png)					| `79`		| Dawnstrike			| Zhou Tai			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhoutai-3.png)
`12`		| Sword of Heaven				| Cao Cao				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caocao-1.png)						| `80`		| Duskstrike			| Zhou Tai			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhoutai-2.png)
`13`		| Blue Blade					| Cao Cao				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caocao-3.png)						| `81`		| Flying Nimbus			| Ling Tong			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lingtong-1.png)
`14`		| Seven Star Sword				| Cao Cao				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caocao-2.png)						| `82`		| Rising Nimbus			| Ling Tong			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lingtong-3.png)
`15`		| Red Dusk						| Zhou Yu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhouyu-1.png)						| `83`		| Lofting Nimbus		| Ling Tong			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lingtong-2.png)
`16`		| Dark Night					| Zhou Yu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhouyu-3.png)						| `84`		| Tryant Strike			| Sun Ce			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunce-1.png)
`17`		| Scarlet Dawn					| Zhou Yu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhouyu-2.png) 					| `85`		| Glimmer Strike		| Sun Ce			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunce-3.png)
`18`		| Silver Swallow				| Lu Xun				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/luxun-1.png) 						| `86`		| Stoic Strike			| Sun Ce			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunce-2.png)
`19`		| Blue Falcon					| Lu Xun				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/luxun-3.png) 						| `87`		| Dragon's Might		| Sun Quan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunquan-1.png)
`20`		| Jade Warbler					| Lu Xun				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/luxun-2.png)  					| `88`		| Heaven's Might		| Sun Quan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunquan-3.png)
`21`		| Madder Rose					| Sun Shang Xiang		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/ssx-1.png)  						| `89`		| Tiatan's Might		| Sun Quan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunquan-2.png)
`22`		| Wisteria Breeze				| Sun Shang Xiang		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/ssx-3.png)  						| `90`		| Ironhorse Glaive		| Ma Chao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/machao-1.png)
`23`		| Lotus Bow						| Sun Shang Xiang		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/ssx-2.png)  						| `91`		| Dragonrun Glaive		| Ma Chao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/machao-3.png)
`24`		| Crescent Moon					| Gan Ning				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/ganning-1.png)  					| `92`		| Warsteed Glaive		| Ma Chao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/machao-2.png)
`25`		| Dancing Dragon				| Gan Ning				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/ganning-3.png)  					| `93`		| Immortal Blade		| Huang Zhong		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/huangzhong-1.png)
`26`		| Wing Blade					| Gan Ning				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/ganning-2.png) 					| `94`		| Battle Master Blade	| Huang Zhong		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/huangzhong-3.png)
`27`		| Elder Sword					| Sun Jian				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunjian-1.png)  					| `95`		| Princeps Blade		| Huang Zhong		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/huangzhong-2.png)
`28`		| Nine Hook Sword				| Sun Jian				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunjian-3.png)  					| `96`		| The Awakener			| Wei Yan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/weiyan-1.png)
`29`		| Golden Pheonix				| Sun Jian				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/sunjian-2.png)   					| `97`		| Bone Splitter			| Wei Yan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/weiyan-3.png)
`30`		| Dragon Spike					| Zhao Yun				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhaoyun-1.png)   					| `98`		| Stormhowl				| Wei Yan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/weiyan-2.png)
`31`		| Dragon Fang					| Zhao Yun				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhaoyun-3.png)   					| `99`		| Blue Dragon Ji		| Guan Ping			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/guanping-1.png)
`32`		| Dragon Talon					| Zhao Yun				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhaoyun-2.png)    				| `100`		| Black Dragon Ji		| Guan Ping			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/guanping-3.png)
`33`		| Blue Dragon					| Guan Yu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/guanyu-1.png)    					| `101`		| White Dragon Ji		| Guan Ping			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/guanping-2.png)
`34`		| Black Dragon					| Guan Yu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/guanyu-3.png)    					| `102`		| Firestorm Staff		| Pang Tong			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/pangtong-1.png)
`35`		| White Dragon					| Guan Yu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/guanyu-2.png)     				| `103`		| Blizzard Staff		| Pang Tong			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/pangtong-3.png)
`36`		| Serpent Blade					| Zhang Fei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangfei-1.png)     				| `104`		| Typhoon Staff			| Pang Tong			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/pangtong-2.png)
`37`		| Python Blade					| Zhang Fei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangfei-3.png)     				| `105`		| Wizard Club			| Dong Zhuo			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/dongzhuo-1.png)
`38`		| Viper Blade					| Zhang Fei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangfei-2.png)      				| `106`		| Magus Club			| Dong Zhuo			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/dongzhuo-3.png)
`39`		| Brilliance					| Zhuge Liang			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhugeliang-1.png)      			| `107`		| Augur Club			| Dong Zhuo			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/dongzhuo-2.png)
`40`		| Distinction					| Zhuge Liang			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhugeliang-3.png)      			| `108`		| Sword of Kings		| Yuan Shao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/yuanshao-1.png)
`41`		| Enlightenment					| Zhuge Liang			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhugeliang-2.png)       			| `109`		| Sword of Severity		| Yuan Shao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/yuanshao-3.png)
`42`		| Strength and Virtue			| Liu Bei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/liubei-1.png)       				| `110`		| North Star Sword		| Yuan Shao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/yuanshao-2.png)
`43`		| Heaven and Earth				| Liu Bei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/liubei-3.png)       				| `111`		| Blaze Staff			| Zhang Jiao		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangjiao-1.png)
`44`		| Yin and Yang					| Liu Bei				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/liubei-2.png)        				| `112`		| Blight Staff			| Zhang Jiao		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangjiao-3.png)
`45`		| Moonflower					| Diao Chan				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/diaochan-1.png)        			| `113`		| Judgement Staff		| Zhang Jiao		| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhangjiao-2.png)
`46`		| Dewflower						| Diao Chan				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/diaochan-3.png)        			| `114`		| Allure				| Zhen Ji			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhenji-1.png)
`47`		| Rainflower					| Diao Chan				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/diaochan-2.png)         			| `115`		| Charm					| Zhen Ji			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhenji-3.png)
`48`		| Sky Piercer					| Lu Bu					| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lubu-1.png)         				| `116`		| Seduction				| Zhen Ji			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhenji-2.png)
`49`		| Demon Bane					| Lu Bu					| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lubu-3.png)         				| `117`		| True Grace			| Xiao Qiao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xq-1.png)
`50`		| Heron Blade Halberd			| Lu Bu					| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/lubu-2.png)          				| `118`		| True Beauty			| Xiao Qiao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xq-3.png)
`51`		| Bone Crusher					| Xu Zhu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xuzhu-1.png)          			| `119`		| True Luster			| Xiao Qiao			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xq-2.png)
`52`		| Chaos Crusher					| Xu Zhu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xuzhu-3.png)          			| `120`		| Emerald Dew			| Yue Ying			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/yueying-1.png)
`53`		| Whirlwind Crusher				| Xu Zhu				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xuzhu-2.png)           			| `121`		| Emerald Veil			| Yue Ying			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/yueying-3.png)
`54`		| Heavens Destroyer				| Xiahou Yuan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xiahouyuan-1.png)           		| `122`		| Emerald Mist			| Yue Ying			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/yueying-2.png)
`55`		| Heavens Smasher				| Xiahou Yuan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xiahouyuan-3.png)
`56`		| Heavens Cutter				| Xiahou Yuan			| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xiahouyuan-2.png)
`57`		| Destroyer						| Xu Huang				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xuhuang-1.png)
`58`		| Annihilator					| Xu Huang				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xuhuang-3.png)
`59`		| Obliterator					| Xu Huang				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/xuhuang-2.png)
`60`		| Splendor						| Zhang He				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhanghe-1.png)
`61`		| Mystery						| Zhang He				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhanghe-3.png)
`62`		| Ostentation					| Zhang He				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/zhanghe-2.png)
`63`		| Phoenix Wing					| Cao Ren				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caoren-1.png)
`64`		| Dragon Scale					| Cao Ren				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caoren-3.png)
`65`		| Tortoise Bite					| Cao Ren				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caoren-2.png)
`66`		| Havoc							| Cao Pi				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caopi-1.png)
`67`		| Mayhem						| Cao Pi				| ![](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/weapon-img/caopi-3.png)


This of course lends itself to swapping weapons between officers, *without* the risk of irreversibly fucking up your 
character's inventory/weapons permenantly, as is the case with the stat transfer method earlier. If you simply navigate through
your officer's weapon slots 16 bytes at a time, starting from their `id`, you can fill up your inventory with a bunch
of different weapons that you're absolutely not supposed to be using:

![custom weapons](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/custom-inv.gif)

But, unlike in later entries to the series where weapon switching is a mechanic, the moveset and animations doesn't change. 
But with some imagination and some help from the table above, you can end up with some pretty decent looking swaps...

Liu Bei with the twin fans:<br>
![lui bei with fans](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_11.png)
<br>
<br>

Giving Zhou Yu Dian Wei's weapon *somehow* also works pretty well!!:
![zhou yu wtf](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_12.png)
![zhou yu wtf](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/zhouyu-min.gif)
<br>
<br>

Turn out Sima Yi doesn't actually have hands:
![sima scissorhands](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_15.png)
<br>
<br>

Lu Xun holding Xu Zhu's 600 pound club with his wrist:
![sima scissorhands](https://raw.githubusercontent.com/cnopt/DW6-Reverse-Engineering/main/Screenshot_14.png)




#### Damage

This address seems to function as an offset to add to the weapon's base damage. As you might expect, third-tier
weapons have a higher base damage than first-tier ones. For example, Guan Yu's 'Blue Dragon' with a `damage` value of `0`
results in a weapon with 60 damage. Increasing this value to `06` changes the weapon's damage to 66. Keeping this value
at `06` and changing the `id` of the weapon to `33`, i.e. his third-tier weapon, gives us 70 damage. Reverting the `damage`
back to `0`, it goes down to 64 - still higher than the base damage of his first-tier blade. 

* The maximum value seems to be `32` - the UI can't display a higher value than 100 damage. The game might still keep track of it, though.
* This base damage doesn't change across officers/levels

An officer's second-tier weapon actually has a lower base power, since these weapons instead favour attack speed. Of course,
increasing the `damage` value can easily solve this. Sadly, the speed and range of a weapon aren't stored in save data.



#### Skills

Weapons can have up to *five* skills attached to them. The value shuffles sets of 1-5 of them, in the same way as horse abilties.
However this means things get even more complex.


| Skill								| Description
| --------							| -----------	
*Values between 1-15 shuffle these skills:*
Air Wave						    | Upon attack, sends out a wave of air that damages enemies
Mystic Seal							| Elemental damage is stengthened
True Musou							| Every Musou attack is a True Musou
Leech								| Life gauge recovers slightly when inflicting damage
*Values between 16-31 shuffle these skills:*
Concentration						| Musou gauge depletes quickly, but is stengthened
Air Wave						    | ''
Mystic Seal							| ''
True Musou							| ''
Leech								| ''
*Values between 32-63 shuffle these skills:*
Balance								| Gain the advantage in a weapon deadlock
Concentration						| ''
Air Wave						    | ''
Mystic Seal							| ''
True Musou							| ''
Leech								| ''
*Values between 64-127 shuffle these skills:*
Beserk								| Attack increases greatly, but defence drops massively
Balance								| ''
Concentration						| ''
Air Wave						    | ''
Mystic Seal							| ''
True Musou							| ''
Leech								| ''
*Values between 128-255 shuffle these skills:*
Renbu Spirit						| Chains stay active longer
Beserk								| ''
Balance								| ''
Concentration						| ''
Air Wave						    | ''
Mystic Seal							| ''
True Musou							| ''
Leech								| ''
*Values between 256-511 shuffle these skills:*
Arrow Sight							| Deflect arrows while attacking
Renbu Spirit						| ''
Beserk								| ''
Balance								| ''
Concentration						| ''
Air Wave						    | ''
Mystic Seal							| ''
True Musou							| ''
Leech								| ''
*Values between 512-1024 shuffle these skills:*
Flash								| Chance to instantly defeat weaker opponents and deal heavy damage to officers
Arrow Sight							| ''
Renbu Spirit						| ''
Beserk								| ''
Balance								| ''
Concentration						| ''
Air Wave						    | ''
Mystic Seal							| ''
True Musou							| ''
Leech								| ''






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
| `007B3B04`			 | Equipped outfit
