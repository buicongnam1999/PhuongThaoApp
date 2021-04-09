<template>
    <div>
        <the-header />
        <the-content />
        <the-footer />
    </div>
</template>

<script>
import TheFooter from '../components/TheFooter.vue'
import TheHeader from '../components/TheHeader.vue'
import TheContent from '../components/TheContent.vue'
export default {
  components: { TheHeader, TheFooter,TheContent },
    
}
</script>

<style>

</style>