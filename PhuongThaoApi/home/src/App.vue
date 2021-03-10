<template>
  <div id="app">
      <the-header />
      <the-content />
      <the-footer />
  </div>
</template>

<script>
import TheContent from './components/TheContent.vue';
import TheFooter from './components/TheFooter.vue';
import TheHeader from './components/TheHeader';
export default {
  components:{
    TheHeader,
    TheFooter,
    TheContent
  }
}
</script>

<style>
#app{
  /* font-family: OpenSans; */
  width: 100%;
}
*{
  margin: 0;
  padding: 0;
}
</style>
