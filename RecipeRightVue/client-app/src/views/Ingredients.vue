<template>
  <div>
    <section class="hero is-medium is-primary">
      <div class="hero-body">
        <div class="container">
          <div class="columns">
            <div class="column is-8-desktop is-offset-2-desktop">
              <h1 class="title is-2 is-spaced">
                Ingredients
              </h1>
              <h2 class="subtitle is-4">
                Use this page to manage all your ingredients!
              </h2>
            </div>
          </div>
        </div>
      </div>
    </section>

    <section class="section">
      <div class="container">
        <div class=" columns">
          <div class="column is-half is-offset-one-quarter">
            <form @submit.prevent="formSubmit">
              <label class="label">Add new ingredient</label>
              <div class="field is-grouped">
                <div class="control is-expanded">
                  <input
                    v-model="newIngredientName"
                    class="input"
                    type="text"
                    placeholder="Ingredient name"
                  />
                </div>
                <div class="control">
                  <button type="submit" class="button is-info">
                    Add
                  </button>
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
    </section>

    <section class="section">
      <div class="container">
        <div class="columns">
          <div class="column is-8-desktop is-offset-2-desktop">
            <div class="content">
              <div
                class="level"
                v-for="ingredient in ingredients"
                :key="ingredient.Id"
              >
                <div class="level-left">
                  <div class="level-item">{{ ingredient.name }}</div>
                </div>
                <div class="level-right">
                  <span class="tag is-primary is-light">ingredient</span>
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
  name: 'Ingredients',
  components: {},
  data() {
    return {
      ingredients: [],
      newIngredientName: '',
      error: ''
    };
  },
  async mounted() {
    this.updateIngredients();
  },
  methods: {
    async updateIngredients() {
      try {
        const result = await fetch('api/ingredients');
        this.ingredients = await result.json();
      } catch {
        alert('Fail.');
      }
    },
    async formSubmit() {
      try {
        const body = JSON.stringify({ Name: this.newIngredientName });

        await fetch('api/ingredients', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
            // 'Content-Type': 'application/x-www-form-urlencoded',
          },
          body
        });

        this.updateIngredients();
      } catch (error) {
        this.error = error;
      }
    }
  }
};
</script>
