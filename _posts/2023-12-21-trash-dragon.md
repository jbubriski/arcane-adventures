---
layout:     monster
title:      "Trash Dragon - NPC for DnD"
title_simple:      "Trash Dragon"
date:       2023-12-21 10:00:00 -0400
categories: monster
tags:       dnd dnd-5e npc tier-1 tier-2 tier-3 tier-4 legendary
image_base_path: /assets/images/trash-dragon/
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
speed: 40 ft., climb 30ft.
---

<div class="stat-block">
    {% assign image = page.images[0] %}
    {% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

    <h2 class="monster-name">Adult Trash Dragon</h2>
    <p><em>Huge Dragon, Chaotic Neutral</em></p>

    <hr />

    {% include monsters/core-stats.html %}

    <hr />

    {% include monsters/stats.html str=20 dex=10 con=26 wis=16 int=14 cha=20 %}

    <hr />

    <div><strong>Saving Throws</strong> DEX {% include tools/d20-roll.html type="Dexterity Saving Throw" roll="+6" %}, CON {% include tools/d20-roll.html type="Constitution Saving Throw" roll="+10" %}, WIS {% include tools/d20-roll.html type="Wisdom Saving Throw" roll="+7" %}, CHA {% include tools/d20-roll.html type="Charisma Saving Throw" roll="+8" %}</div>
    <div><strong>Skills</strong> Deception {% include tools/d20-roll.html type="Deception Skill Check" roll="+1" %}, Perception {% include tools/d20-roll.html type="Perception Skill Check" roll="+13" %}</div>
    <div><strong>Damage Immunities</strong> Acid</div>
    <div><strong>Senses</strong> Blindsight 60 ft., Darkvision 120 ft., Passive Perception 23</div>
    <div><strong>Languages</strong> Common, Undercommon, Draconic</div>
    <div><strong>Challenge 12</strong> (11,500 XP)</div>
    <div><strong>Proficiency Bonus</strong> +5</div>

    <hr />

    <div><strong>Legendary Resistance (3/Day)</strong> If the dragon fails a saving throw, it can choose to succeed instead.</div>


    <h2 id="actions">Actions</h2>

    <p><strong>Multiattack.</strong> It then makes three attacks: one with its bite and two with its claws.</p>

    <p><strong>Bite.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 8" text="+8" %} to hit, reach 10 ft., one target. Hit: 24 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="3d10 + 6" %}) piercing damage.</p>

    <p><strong>Punch.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 10" text="+10" %} to hit, reach 5 ft., one target. Hit: 12 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="2d6 + 4" %}) bludgeoning damage.</p>

    <p><strong>Breath Weapons (Recharge 5–6).</strong> The dragon uses one of the following breath weapons.</p>

    <p><strong>Trash Breath.</strong> The dragon exhales trash in a 30-foot cone. Each creature in that area must make a DC 18 Dexterity saving throw, taking 54 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="12d8" %}) bludgeoning damage on a failed save, or half as much damage on a successful one.</p>

    <p><strong>Burp.</strong> The dragon exhales noxious fumes in a 15-foot cone. Each creature in that area must make a DC 15 Constitution saving throw, taking 54 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="12d8" %}) poison damage on a failed save, or half as much damage on a successful one.</p>


    <h2 id="legendary_actions">Legendary Actions</h2>

    <p>The dragon can take 3 legendary actions, choosing from the options below. Only one legendary action option can be used at a time and only at the end of another creature's turn. The dragon regains spent legendary actions at the start of its turn.</p>

    <p><strong>Guzzle.</strong> The dragon consumes any items within 5 feet of it. If there are enough items or trash around it, its breath weapon attack is recharged.</p>

    <p><strong>Tail Rake.</strong> The dragon rakes its tail along the ground flinging rocks, debris, or any trash it spewed earlier in a 15 foot cone. Each creature in that area must make a DC 15 Dexterity saving throw, taking 24 ({% include tools/dice-roll.html type="Bludgeoning damage" roll="5d8" %}) bludgeoning damage on a failed save, or half as much damage on a successful one.</p>

    <p><strong>Wing Attack (Costs 2 Actions).</strong> The dragon beats its wings. Each creature within 10 feet of the dragon must succeed on a DC 19 Dexterity saving throw or take 13 ({% include tools/dice-roll.html type="Bludgeoning damage" roll="2d6 + 6" %}) bludgeoning damage and be knocked prone. The dragon can then fly up to half its flying speed.</p>
</div>


{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

## Whatever

It's rumored deep under the sewers of Hemadal,
Each creature of the dragon's choice that is within 120 feet of the dragon and aware of it must succeed on a DC 16 Charisma saving throw or become Frightful Presence. Each creature of the dragon's choice that is within 120 feet of the dragon and aware of it must succeed on a DC 16 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the dragon's Frightful Presence for the next 24 hours.


## Whatever 2

Each creature of the dragon's choice that is within 120 feet of the dragon and aware of it must succeed on a DC 16 Charisma saving throw or become Frightful Presence. Each creature of the dragon's choice that is within 120 feet of the dragon and aware of it must succeed on a DC 16 Wisdom saving throw or become frightened for 1 minute. A creature can repeat the saving throw at the end of each of its turns, ending the effect on itself on a success. If a creature's saving throw is successful or the effect ends for it, the creature is immune to the dragon's Frightful Presence for the next 24 hours.

- t on itself on a success. If a creature's saving throw is successful or
- t on itself on a success. If a creature's saving throw is successful or
- t on itself on a success. If a creature's saving throw is successful or

t on itself on a success. If a creature's saving throw is successful or

## Additional Images

{% include additional-images-dall-e.html %}

{% include additional-images.html %}
