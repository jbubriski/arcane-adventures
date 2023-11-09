---
layout:       home
title:        Magic Items
description:  A collection of magic items for your DND 5e or tabletop game
permalink:    /magic-items/
---

Here is a collection of magic items I've created for your enjoyment in your DND 5e, Pathfinder, or tabletop game:

<div>
{% for post in site.categories.magic-item %}
  <div>
    <a href="{{ post.url }}">{{ post.title }}</a>
    <div class="tags">
    {% for tag in post.tags %}
      <span class="tag">{{ tag }}</span>
    {% endfor %}
    </div>
  </div>
{% endfor %}
</div>