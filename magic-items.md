---
layout: home
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