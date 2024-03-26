---
layout:         monster
title:          "Ragdroth the Demon - Monster for DnD"
title_simple:   "Ragdroth the Demon"
date:           2024-02-29 10:00:00 -0400
categories:     monster
tags:           dnd dnd-5e tier-3 tier-4 fiend demon
image_base_path: /assets/images/ragdroth-the-demon/
image:     ragdroth-the-demon-01
images:
    - src: ragdroth-the-demon-01
      alt: Ragdroth the Demon
    - src: ragdroth-the-demon-02
      alt: Alternate image of Ragdroth the Demon
imagesExtra:
    - src: ragdroth-the-demon-extra-01
      alt: Extra image for Ragdroth the Demon
    - src: ragdroth-the-demon-extra-02
      alt: Extra image for Ragdroth the Demon
cr: 10
ac: 18 (natural armor)
hp: 172
hp_roll: 16d8 + 100
speed: 40 ft., Climb 40ft., Swim 40ft.
---

<div class="read-aloud">
    Ragdroth stared down at his hands with a furrowed brow. His bright green skin made him pause for a moment. Green wasn't his favorite color. It was red. He closed his eyes for a moment and a grin stretched across his long face. He remembered the day he wore red from head to toe.
</div>

<!--more-->

<div class="read-aloud">
    He had stumbled on a group dwarves in the forest. They were probably heading back from a mining trip, off to sell the ore they had pulled out of the ground. Their sprits were high and they were singing some stupid song. He didn't even know there were dwarves in these parts. He guessed that they didn't know he was in these parts.
</div>
<div class="read-aloud">
    It was late in the day and they all turned their heads towards a noise in the forest where Ragdroth had thrown a pebble. The first dwarf couldn't scream since his head was almost completely severed. There wasn't even a gurgle. The second one caught something out of the corner of her eye and saw Ragdroth's face just as he plunged his claws deep into her chest. He let his claws slide out of her as she fell to the ground.
</div>
<div class="read-aloud">
    The rest of the encounter was a blur and his memory was fuzzy about the details. He remembered lying on the ground, a small heap of bodies strewn about him. He examined himself and realized that every inch of his body was covered with red. If only he could wear red every day.
</div>

<div class="stat-block">
    {% assign image = page.images[0] %}
    {% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

    <h2 class="monster-name">Ragdroth the Demon</h2>
    <p><em>Medium Fiend (Demon), Lawful Evil</em></p>

    <hr />

    {% include monsters/core-stats.html ac=18 hp=224 hp_roll="16d8 + 100" speed="50 ft., Climb 50ft." %}

    <hr />

    {% include monsters/stats.html str=18 dex=22 con=18 wis=14 int=12 cha=8 %}

    <hr />

    <div><strong>Saving Throws</strong> DEX {% include tools/d20-roll.html type="Dexterity Saving Throw" roll="+9" %}, CON {% include tools/d20-roll.html type="Constitution Saving Throw" roll="+7" %}, WIS {% include tools/d20-roll.html type="Wisdom Saving Throw" roll="+5" %}, INT {% include tools/d20-roll.html type="Intelligence Saving Throw" roll="+4" %}, CHA {% include tools/d20-roll.html type="Charisma Saving Throw" roll="+2" %}</div>
    <div><strong>Skills</strong> Deception {% include tools/d20-roll.html type="Deception Skill Check" roll="+4" %}, Perception {% include tools/d20-roll.html type="Perception Skill Check" roll="+5" %}</div>
    <div><strong>Damage Immunities</strong> Fire, Poison</div>
    <div><strong>Senses</strong>Darkvision 120 ft., Passive Perception 16</div>
    <div><strong>Languages</strong> Common, Undercommon, Goblin, Infernal</div>
    <div><strong>Challenge 10</strong> (6,500 XP)</div>
    <div><strong>Proficiency Bonus</strong> +3</div>

    <hr />

    <div><strong>Devil's Sight</strong> Magical darkness doesn't impede Ragdroth's darkvision.</div>

    <div><strong>Magic Resistance</strong>Ragdroth has advantage on saving throws against spells and other magical effects.</div>

    <div><strong>Contortionist</strong>Ragdroth has advantage on dexterity saving throws.</div>


    <h2 id="actions">Actions</h2>

    <p><strong>Multiattack.</strong> Ragdroth makes two slashing attacks.</p>

    <p><strong>Slash.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 8" text="+8" attack="true" %} to hit, reach 10 ft., one target. Hit: 14 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="3d6 + 4" %}) slashing damage.</p>
</div>


{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

## Background

Ragdroth is considered a second-rate devil by his peers.


## Motivation

Ragdroth is driven by his need to earn the respect of other devils.


## Related Stuff



## Additional Images

{% include additional-images-dall-e.html %}

{% include additional-images.html %}
