---
layout:         post
title:          "Chadley's Chatty Chompers - Magic Item for DnD"
title_simple:   "Chadley's Chatty Chompers"
date:           2024-01-02 10:00:00 -0400
categories:     magic-item
tags:           dnd dnd-5e tier-1 tier-2
itemType:       teeth
magicItemType:  wondrous item
rarity:         common
requires_attunement: false
image_base_path: /assets/images/chadleys-chatty-chompers/
image_suffix: png
image:      chadleys-chatty-chompers-01
images:
    - src: chadleys-chatty-chompers-01
      alt: Chadley's Chatty Chompers
    - src: chadleys-chatty-chompers-02
      alt: Alternate image of Chadley's Chatty Chompers
imagesExtra:
    - src: chadleys-chatty-chompers-extra-01
      alt: Extra image for Chadley's Chatty Chompers
    - src: chadleys-chatty-chompers-extra-02
      alt: Extra image for Chadley's Chatty Chompers
---

<p class="read-aloud">
    Chadley removed a curious-looking object from his vest and began violently twisting it in his hand. The orcs stood there, befuddled by what they were witnessing. Holding the object out in front of him, the orcs could now see it was a pair of wooden teeth and they began to chortle. But Chadley's own smile only grew as he hurled the teeth at the naive orcs. Flying through the air, the teeth let out a cackling cry "You've bit off more than you can chew!"
</p>

<!--more-->

As an action, a creature can wind and throw the Chatty Chompers at an enemy within 30 ft. causing the target to make a Dexterity saving throw. On a failed save the Chatty Chompers latch onto one of the limbs of the target and deal xd6 piercing damage. At the end of each of the target's turns, they suffer an additional xd6 damage.

{% include descriptions/tiered-play.html %}

| Tier of Play | Dexterity Saving Throw DC | Initial Damage | Extra damage
| ---------------------- | -- |
| [1][tier1_description] | 10 | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Base Damage" roll="2d6" %} | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Extra Damage" roll="1d6" %}
| [2][tier2_description] | 15 | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Base Damage" roll="3d6" %} | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Extra Damage" roll="1d6" %}
| [3][tier3_description] | 20 | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Base Damage" roll="4d6" %} | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Extra Damage" roll="2d6" %}
| [4][tier4_description] | 25 | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Base Damage" roll="5d6" %} | {% include tools/dice-roll.html type="Chadley's Chatty Chompers Extra Damage" roll="2d6" %}


{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

On a successful save the Chatty Chompers land in the square behind the target, and continue to chatter. Any creature entering that square must make a Dexterity saving throw or suffer the same effects as if it was thrown. The Chatty Chompers deactivate after 1 minute.

When the Chatty Chompers are latched onto a creature, 1 action can be used by any creature within 5 ft. to forcefully rip them off. The target will suffer 1d6 additional damage if the teeth are removed in this way. If 2 actions are dedicated to the removal of the Chatty Chompers then the extra damage is avoided.

For example, the creature suffering the effects can use its action to stop the Chatty Chompers from causing further damage, and another creature can use its action to complete the removal of the teeth.


## Quip

As the Chatty Chompers fly through the air they cackle a quip! Roll on the Quip table below to determine what the Chatty Chompers say as they're flying through the air. The Chatty Chompers continue to say quips every time they cause damage, but the quip is muffled and unintelligible due to it actively gnawing on its victim.

<div markdown="block" class="roll-table js-autoroll js-roll-table">
| {% include tools/dice-roll.html type="Chatty Chompers Quip" roll="1d6" text="Roll" %} | Quip |
| - | ----------- |
| 1 | "You've bit off more than you can chew!"
| 2 | "I think we've bit off more than we can chew!"
| 3 | "[Target Creature Type] is on the menu tonight!"
| 4 | "To a set of chompers, everything looks like dinner!"
| 5 | "Num num num num num num!"
| 6 | Instead of a quip you hear the sound of a dinner bell.

</div>

## DM Notes

Use the table above to scale the effectiveness of the Chatty Chompers for higher tiers of play. If you want to enhance them even more, you can add debuffs for when they're latched onto a target, like an AC penalty. You could also let a poisoner coat the teeth in poison in order to inflict more damage or other lasting effects.


## Additional Images

{% include additional-images-dall-e.html %}

{% include additional-images.html %}


## Attribution

{% include srd_attribution.html %}
