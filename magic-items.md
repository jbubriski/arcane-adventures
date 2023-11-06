---
layout: home
title: Magic Items for your DND 5e or tabletop game
permalink: /magic-items/
---

Magic Items

Here is a colelction of magic items I've created for your enjoyment in your DND game:

<ul>
  {% for post in site.categories.magic-item %}
    <li>
      <a href="{{ post.url }}">{{ post.title }}</a>
    </li>
  {% endfor %}
</ul>