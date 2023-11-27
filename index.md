---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults

layout: home
---

## Welcome to the {{ site.title }}

Check out the latest posts below, or use the menu to find more specfic types of posts.

## Latest Posts

<div class="post-list">
{% for post in site.posts %}
    <div class="post-list-post">
    {% if post.image %}
        {% include list-image.html side="left" src=post.image url=post.url alt=post.title size=120 %}
    {% else %}
        <div class="image-left" style="height: 100px"></div>
    {% endif %}

        <div>
            <a href="{{ post.url }}">{{ post.title }}</a>
        </div>

        <div>
            <em>{{ post.date | date: "%B %-d, %Y" }}</em>
        </div>

        <div class="tags">
        {% for tag in post.tags %}
            <span class="tag">{{ tag }}</span>
        {% endfor %}
        </div>
    </div>
    <div style="clear: both;"></div>
{% endfor %}
</div>