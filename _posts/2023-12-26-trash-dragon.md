---
layout:     monster
title:      "Trash Dragon - NPC for DnD"
title_simple:      "Trash Dragon"
date:       2023-12-26 10:00:00 -0400
categories: monster
tags:       dnd dnd-5e tier-3 tier-4 wip untested
image_base_path: /assets/images/trash-dragon/
image_suffix: png
image:      trash-dragon-01
images:
    - src: trash-dragon-01
      alt: Trash Dragon
    - src: trash-dragon-02
      alt: Alternate image of Trash Dragon
imagesExtra:
    - src: trash-dragon-extra-01
      alt: Extra image for Trash Dragon
    - src: trash-dragon-extra-02
      alt: Extra image for Trash Dragon
    - src: trash-dragon-extra-03
      alt: Extra image for Trash Dragon
    - src: trash-dragon-extra-04
      alt: Extra image for Trash Dragon
ac: 18 (natural armor)
hp: 224
hp_roll: 16d12 + 120
speed: 40 ft., Climb 40ft., Swim 40ft.
---

<div class="stat-block">
    {% assign image = page.images[0] %}
    {% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

    <h2 class="monster-name">Adult Trash Dragon</h2>
    <p><em>Huge Dragon, Chaotic Neutral</em></p>

    <hr />

    {% include monsters/core-stats.html ac=18 hp=224 hp_roll="16d12 + 120" speed="40 ft., Climb 40ft., Swim 40ft." %}

    <hr />

    {% include monsters/stats.html str=20 dex=10 con=26 wis=16 int=14 cha=20 %}

    <hr />

    <div><strong>Saving Throws</strong> DEX {% include tools/d20-roll.html type="Dexterity Saving Throw" roll="+6" %}, CON {% include tools/d20-roll.html type="Constitution Saving Throw" roll="+10" %}, WIS {% include tools/d20-roll.html type="Wisdom Saving Throw" roll="+7" %}, CHA {% include tools/d20-roll.html type="Charisma Saving Throw" roll="+8" %}</div>
    <div><strong>Skills</strong> Deception {% include tools/d20-roll.html type="Deception Skill Check" roll="+4" %}, Perception {% include tools/d20-roll.html type="Perception Skill Check" roll="+13" %}, Stealth {% include tools/d20-roll.html type="Stealth Skill Check" roll="+4" %}</div>
    <div><strong>Damage Immunities</strong> Acid, Poison</div>
    <div><strong>Senses</strong> Blindsight 60 ft., Darkvision 120 ft., Passive Perception 23</div>
    <div><strong>Languages</strong> Common, Undercommon, Draconic</div>
    <div><strong>Challenge 12</strong> (11,500 XP)</div>
    <div><strong>Proficiency Bonus</strong> +5</div>

    <hr />

    <div><strong>Legendary Resistance (3/Day)</strong> If the dragon fails a saving throw, it can choose to succeed instead.</div>


    <h2 id="actions">Actions</h2>

    <p><strong>Multiattack.</strong> The dragon makes three attacks: one bite and two punches.</p>

    <p><strong>Bite.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 8" text="+8" attack="true" %} to hit, reach 10 ft., one target. Hit: 20 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="4d6 + 6" %}) piercing damage.</p>

    <p><strong>Punch.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 10" text="+10" attack=true %} to hit, reach 5 ft., one target. Hit: 12 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="2d6 + 4" %}) bludgeoning damage. Creatures large or smaller that are hit by a punch are knocked back 5 ft.</p>

    <p><strong>Breath Weapons (Recharge 5–6).</strong> The dragon uses one of the following breath weapons.</p>

    <p><strong>Trash Breath.</strong> The dragon exhales trash in a 30-foot cone. Each creature in that area must make a DC 15 Dexterity saving throw, taking 53 ({% include tools/dice-roll.html type="Trash Breath Attack" roll="15d6" %}) bludgeoning damage on a failed save, or half as much damage on a successful one.</p>

    <p><strong>Burp Bubble.</strong> The dragon spews a giant bubble filled with noxious fumes, aimed at a creature within 30 ft. The bubble bursts creating a 15 foot radius cloud of noxious fumes centered on the creature. Each creature in the cloud must make a DC 15 Constitution saving throw, taking 35 ({% include tools/dice-roll.html type="Burp Bubble Attack" roll="10d6" %}) poison damage on a failed save, or half as much damage on a successful one. A creature that ends its turn within the cloud has to repeat the save or suffer the damage (again). The cloud lasts for 1 hour unless dispersed by a strong wind.</p>


    <h2 id="legendary_actions">Legendary Actions</h2>

    <p>The dragon can take 3 legendary actions, choosing from the options below. Only one legendary action option can be used at a time and only at the end of another creature's turn. The dragon regains spent legendary actions at the start of its turn.</p>

    <p><strong>Guzzle.</strong> The dragon rakes its mouth across the ground, consuming any items within 5 feet of it. If there are enough items or trash around it, its breath weapon attack is recharged.</p>

    <p><strong>Dumpster Dive.</strong> If inside its layer, the dragon can dive into the trash hoard. While under the trash hoard there is a low rumble as the dragon tunnels around, but its location isn't visibly obvious and the dragon has complete cover. After 2 adventurers have taken their turns, the dragon will resurface within 30 ft. of the place it went under. When surfacing, each creature within 5 feet of the dragon must make a DC 15 Dexterity saving throw, taking 20 ({% include tools/dice-roll.html type="Bludgeoning damage" roll="4d6 + 6" %}) bludgeoning damage on a failed save, or half as much damage on a successful one.</p>

    <div class="dm-note">While the dragon can't be targeted while under the trash hoard, adventurers can ready their actions to attack when the dragon resurfaces, as long as they're not affected by the resurfacing.</div>

    <p><strong>Improvised Large Trash Slam.</strong> The dragon grabs one large piece of trash (for example, a small boat, tree trunk, or lamp post) and attacks an area on the ground within 10 feet. Each creature within 5 feet of the target must succeed on a DC 15 Dexterity saving throw or take 16 ({% include tools/dice-roll.html type="Bludgeoning damage" roll="3d6 + 6" %}) bludgeoning damage and be knocked back 5 feet from the target.</p>
</div>


{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

## Background

Dwelling deep under the sewers of Hemadal, Trash Dragons rest atop the piles of discarded waste rather than piles of traditional wealth. They find value in the mundane garbage discarded indiscriminately, and sometimes, accidentally, by mortals. While the value of a Trash Dragon's hoard may pale in comparison to that of a typical dragon, they're often a source of arcane, cryptic, and long-forgotten magical sundries.

In adulthood they generally prefer solitude, but younger dragons live in a perpetual commune until big enough to amass their own disgusting hoard.


## Motivations

Like other dragons, Trash Dragons aim to increase their hoard, and generally act in their self-interest. They generally want quantity over quality, but may search out specific magic items to augment the hoard.

| {% include tools/dice-roll.html type="Motivation" roll="1d8" text="Roll" %} | Motivation |
| - | ----------- |
| 1 | Wants to increase its trash hoard by disrupting society.
| 2 | Wants to increase its trash hoard through trading.
| 3 | Wants the adventurers to retrieve some magic items.
| 4 | Wants the adventurers to find a way to increase the trash hoard.
| 5 | Wants to ally with the nearby city to increase the trash hoard.
| 6 | Is content with its trash hoard and wants to be left alone.
| 7 | Wants to lure the adventurers in through deception to steal their items.
| 8 | Wants to add the adventurers' bodies to their trash horde.


## Related Magic Item Ideas

Here are some magic items that the Trash Dragon might be interested in finding.

| {% include tools/dice-roll.html type="Magic Items" roll="1d6" text="Roll" %} | Magic Items |
| - | ----------- |
| 1 | Housewarming Prank - A cracked jug that slowly and continually leaks wine, but contains no wine.
| 2 | Sharding Bowl - A glass bowl that reconstitutes itself when smashed, leaving behind extra shards.
| 3 | Stank Powder - A special alchemical powder that will react with the offgassing around the trash hoard.
| 4 | Trash Chute - A metal pipe that expands and bores through surfaces when activated.
| 5 | Heinous Hairball - A hairball from a magical creature that reacts to magical energy and grows.
| 6 | Francis the Pig - Francis the Pig had a portal to another plane opened within its bowels. It will produce an unnatural amount of poop.


## Lair and Lair Actions

The Trash Dragon isn't the only inhabitant of its lair. Worms and rats of various sizes occupy the trash hoard and have a symbiotic relationship with the dragon. Worms and other smaller insects break down some of the rotting food, and rats act like pets to the dragon. The rats may also fetch valuable items for the dragon as they venture out of the lair. Sometimes the dragon keeps with less desirable mimics as pets to help guard their hoard.

<strong>Swarm of Rats.</strong> A Swarm of Rats appears around the most isolated creature. The swarm has 32 hit points, has resistance to piercing damage, and is vulnerable to area of effect attacks. Swarm Attack. Melee Weapon Attack: +6 to hit, reach 5 ft., one target. Hit: 11 (2d6 + 4) piercing damage. If the rat swarm takes damage to reduce its hp below 25% (8 hp), the swarm uses its reaction to disperse into the trash pile.

<div class="stat-block">
    <h2 class="monster-name">Rat Swarm</h2>
    <p><em>Swarm, Beast</em></p>

    <hr />

    {% include monsters/core-stats.html ac=12 hp=22 hp_roll="4d6 + 6" speed="30 ft., Climb 30ft., Swim 30ft." %}
    Swarms can occupy the space of other creatures.

    <hr />

    <h2 id="actions">Actions</h2>

    <p><strong>Nibble.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 56" text="+6" attack=true %} to hit, reach 5 ft., one target. Hit: 10 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d6 + 6" %}) piercing damage.</p>
</div>

<strong>Mimic Surprise.</strong> A nearby large item springs to life. Use the basic Mimic stat block.


## Additional Images

{% include additional-images-dall-e.html %}

{% include additional-images.html %}
