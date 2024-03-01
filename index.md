---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults

layout: home
---

## Welcome to Arcane Adventures

Check out the latest posts below, or use the menu to find more specific types of posts.

## Latest Post

{% assign postIndex = 0 %}

<div class="post-list">
{% for post in site.posts %}
    <div class="post-list-post">
    {% if postIndex == 1 %}
        <h2>All Posts</h2>
    {% endif %}
    {% if post.image %}
        {% include list-image.html side="left" image_base_path=post.image_base_path src=post.image url=post.url image_suffix=post.image_suffix alt=post.title size=120 %}
    {% else %}
        <div class="image-empty image-left" style="height: 100px"></div>
    {% endif %}

        <div class="post-text">
            <div>
                <a href="{{ post.url }}">{{ post.title }}</a>
            </div>

            <div>
                <em>{{ post.date | date: "%B %-d, %Y" }}</em>
            </div>

            {% if postIndex == 0 %}
            <div>
                <em>{{ post.excerpt }}</em>
            </div>
            {% endif %}

            <div class="tags">
            {% for tag in post.tags %}
                <span class="tag">{{ tag }}</span>
            {% endfor %}
            </div>
        </div>
    </div>
    <div style="clear: both;"></div>
    {% assign postIndex = postIndex | plus:1 %}
{% endfor %}
</div>