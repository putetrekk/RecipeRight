<template>
  <div>
    <section class="hero is-medium is-primary">
      <div class="hero-body">
        <div class="container">
          <div class="columns">
            <div class="column is-8-desktop is-offset-2-desktop">
              <h1 class="title is-2 is-spaced">
                Hello Recipes!
              </h1>
              <h2 class="subtitle is-4">
                Congratulations! You're running <strong>RecipeRight</strong>.
              </h2>
            </div>
          </div>
        </div>
      </div>
    </section>

    <section class="section">
      <div class="container">
        <div class="columns">
          <div class="column is-8-desktop is-offset-2-desktop">
            <div class="content">
              <div class="level" v-for="recipe in recipes" :key="recipe.Id">
                <div class="level-left">
                  <div class="level-item">{{ recipe.Name }}</div>
                </div>
                <div class="level-right"></div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
export default {
  name: 'Home',
  components: {},
  data() {
    return {
      recipes: []
    };
  },
  async mounted() {
    try {
      const result = await fetch('api/recipes');
      this.recipes = await result.json();
    } catch {
      alert('Fail.');
    }
  }
};
</script>
