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
              <div class="level">
                <div class="level-left">
                  <h2>Recipes</h2>
                </div>
                <div class="level-right">
                  <router-link
                    class="button is-text"
                    :to="{ name: 'Create Recipe' }"
                    >Create recipe</router-link
                  >
                </div>
              </div>
              <div class="level" v-for="recipe in recipes" :key="recipe.Id">
                <div class="level-left">
                  <div class="level-item is-size-4">{{ recipe.name }}</div>
                  <p class="level-item">
                    Steps: {{ recipe.steps !== null ? recipe.steps.length : 0 }}
                  </p>
                </div>
                <div class="level-right"></div>
              </div>
              <div class="level" v-if="recipes.length == 0">
                <div class="level-left">
                  <div class="level-item">
                    Oh no! We're all out of recipes...
                  </div>
                </div>
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
