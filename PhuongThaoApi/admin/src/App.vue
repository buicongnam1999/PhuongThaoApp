<template>
    <div id="app">
       <the-header />
       <the-side-bar />
       <the-content />
       <the-login :isHide="isHide" @CloseForm="CloseLogin"/>
    </div>
</template>
<script>
import TheSideBar from './components/side-bar/TheSideBar.vue'
import TheContent from './components/TheContent.vue'
import TheHeader from './components/TheHeader'
import TheLogin from './components/TheLogin.vue'
export default {
  components:{
    TheHeader,
    TheContent,
    TheSideBar,
    TheLogin
  },
  data() {
    return {
       isHide: false
    }
  },
  methods: {
      CloseLogin: function() {
          this.isHide = !this.isHide
      }
  },
  
}
</script>
<style scoped>
@import "./assets/css/style.css";
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  color: #2c3e50;
  width: 101.15%;
  padding: 0px;
  margin: -8px;
}

</style>
