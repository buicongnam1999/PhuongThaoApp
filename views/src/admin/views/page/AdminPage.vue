<template>
    <div>
        <the-header @Logout="Logout"/>
        <the-side-bar />
        <the-content />
    </div>
</template>

<script>
import TheSideBar from '../../components/side-bar/TheSideBar.vue'
import TheContent from '../../components/TheContent.vue'
import TheHeader from '../../components/TheHeader.vue'
export default {
    TheHeader,
    TheContent,
    TheSideBar,
}
</script>

<style>

</style>