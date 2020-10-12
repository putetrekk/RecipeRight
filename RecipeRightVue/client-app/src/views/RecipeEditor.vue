<template>
  <section class="section">
    <div class="container">
      <div class="columns">
        <div class="column is-8-desktop is-offset-2-desktop">
          <div class="content">
            <div class="level">
              <div class="level-left">
                <div class="field">
                  <p class="control">
                    <input
                      class="input is-size-5"
                      type="text"
                      v-model="recipe"
                    />
                  </p>
                </div>
              </div>
            </div>

            <div class="media block" v-for="(step, index) in steps" :key="step">
              <figure class="media-left">
                <p class="is-4">{{ index + 1 }}.</p>
              </figure>
              <div class="media-content">
                <div class="field">
                  <div class="control">
                    <textarea
                      v-model="step.action"
                      class="textarea is-info"
                      placeholder="Primary textarea"
                    >
                    </textarea>
                  </div>
                </div>
              </div>
              <div class="media-right">
                <button class="delete" @click="removeStep(step)"></button>
              </div>
            </div>

            <div class="field is-grouped">
              <div class="control">
                <button class="button is-info is-light" @click="addStep">
                  Add step
                </button>
              </div>
              <div class="field">
                <div class="control">
                  <button class="button is-primary is-light" @click="submit">
                    Submit
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>

<script>
export default {
  name: 'RecipeEditor',
  data() {
    return {
      recipe: 'Recipe Name',
      steps: [{ action: 'Add a bucket of milk.' }]
    };
  },
  methods: {
    addStep() {
      this.steps.push({
        action: 'Add another bucket of milk.'
      });
    },
    removeStep(step) {
      this.steps = this.steps.filter(s => s !== step);
    },
    async submit() {
      const requestBody = {
        Name: this.recipe,
        Steps: this.steps.map(step => {
          return {
            action: step.action
          };
        })
      };

      const result = await fetch('api/recipes', {
        body: JSON.stringify(requestBody),
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
          // 'Content-Type': 'application/x-www-form-urlencoded',
        }
      });
    }
  }
};
</script>

<style></style>
