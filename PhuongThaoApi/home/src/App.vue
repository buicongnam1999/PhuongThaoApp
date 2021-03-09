<template>
  <div id="app">
      <div class="wrapper">
          <the-header />
          <the-content />
          <the-footer />
      </div>
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
  font-family: OpenSans;
  font-size: 13px;
  color: #fff;
}



</style>
