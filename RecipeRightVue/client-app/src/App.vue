<template>
  <div class="page has-background-white-bis">
    <NavBar class="has-background-white-ter"></NavBar>

    <router-view></router-view>

    <Footer class="has-background-primary-light"></Footer>
  </div>
</template>

<script>
import '@fortawesome/fontawesome-free/css/all.css';

// Import Bulma with our theme
import './assets/theme.scss';

import NavBar from './components/NavBar';
import Footer from './components/Footer';

export default {
  components: {
    NavBar,
    Footer
  },
  mounted: function() {}
};
</script>

<style lang="scss" scoped></style>
