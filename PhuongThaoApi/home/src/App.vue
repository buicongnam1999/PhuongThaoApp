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
    TheContent,
  }
}
</script>

<style>
#app{
  /* font-family: OpenSans; */
  width: 100%;
}::-webkit-scrollbar {
    width: 8px !important;
    height: 1px !important;
    z-index: 1231232123421;
}

::-webkit-scrollbar-track {
    width: 6px;
    background-color: #bbb;
}

::-webkit-scrollbar-thumb {
    background-color: #808080;
    border-radius: 8px;
}
*{
  margin: 0;
  padding: 0;
}
</style>
